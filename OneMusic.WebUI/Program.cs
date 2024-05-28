using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.BusinessLayer.Concrete;
using OneMusic.BusinessLayer.Container;
using OneMusic.BusinessLayer.Validators;
using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Concrete;
using OneMusic.DataAccessLayer.Context;
using OneMusic.EntityLayer.Entities;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCustomServices();


builder.Services.AddDbContext<OneMusicContext>(); //Context Taným
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()); //Validator

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<OneMusicContext>().AddErrorDescriber<CustomErrorDescriber>(); //Identity Taným ve custom error tanýmý


builder.Services.AddControllersWithViews(option =>
{

	//var authorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

	//option.Filters.Add(new AuthorizeFilter(authorizePolicy)); //Proje Bazýnda Authorize
});


builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.ExpireTimeSpan = TimeSpan.FromMinutes(100); //AUT KALMA ZAMANI
	options.AccessDeniedPath = "/ErrorPage/Index/";
	options.LoginPath = "/Login/Index/";
	options.LogoutPath = "/Login/Logout";
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}"); //Hata sayfasý yönlendirme


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Login}/{action=Index}/{id?}");


app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");


app.Run();
