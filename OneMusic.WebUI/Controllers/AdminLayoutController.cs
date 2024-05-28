using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OneMusic.EntityLayer.Entities;

namespace OneMusic.WebUI.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AdminLayoutController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public AdminLayoutController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
