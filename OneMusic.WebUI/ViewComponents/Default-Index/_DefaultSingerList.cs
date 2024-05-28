using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.DataAccessLayer.Context;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
    public class _DefaultSingerList : ViewComponent
    {
        private readonly OneMusicContext _oneMusicContext;

        public _DefaultSingerList(IAlbumService albumService, OneMusicContext oneMusicContext)
        {
            _oneMusicContext = oneMusicContext;
        }


        public IViewComponentResult Invoke()
        {

            var values = (from user in _oneMusicContext.Users
                          join userRole in _oneMusicContext.UserRoles
                          on user.Id equals userRole.UserId
                          where userRole.RoleId == 2
                          select user)
                          .ToList();

            ViewBag.Values = values;
            return View(values);
        }

    }
}
