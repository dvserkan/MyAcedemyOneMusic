using Microsoft.Extensions.DependencyInjection;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.BusinessLayer.Concrete;
using OneMusic.DataAccessLayer.Abstract;
using OneMusic.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
          services.AddScoped<IAboutDal, EfAboutDal>();
          services.AddScoped<IAboutService, AboutManager>();

          services.AddScoped<ISingerDal, EfSingerDal>();
          services.AddScoped<ISingerService, SingerManager>();
          
          services.AddScoped<IAlbumDal, EfAlbumDal>();
          services.AddScoped<IAlbumService, AlbumManager>();
          
          services.AddScoped<IBannerDal, EfBannerDal>();
          services.AddScoped<IBannerService, BannerManager>();
          
          services.AddScoped<IMessageDal, EfMessageDal>();
          services.AddScoped<IMessageService, MessageManager>();
          
          services.AddScoped<ISongDal, EfSongDal>();
          services.AddScoped<ISongService, SongManager>();

          services.AddScoped<IContactDal, EfContactDal>();
          services.AddScoped<IContactService, ContactManager>();
          
          services.AddScoped<IEventDal, EfEventDal>();
          services.AddScoped<IEventService, IEventManager>();

        }
    }
}