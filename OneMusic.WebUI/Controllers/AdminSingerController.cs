using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.BusinessLayer.Validators;
using OneMusic.DataAccessLayer.Context;
using OneMusic.EntityLayer.Entities;

namespace OneMusic.WebUI.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AdminSingerController : Controller
    {
        private readonly ISingerService _singerService;
        private readonly OneMusicContext _oneMusicContext;

        public AdminSingerController(ISingerService singerService, OneMusicContext oneMusicContext)
        {
            _singerService = singerService;
            _oneMusicContext = oneMusicContext;
        }

        public IActionResult Index()
        {
            var values = (from user in _oneMusicContext.Users
                          join userRole in _oneMusicContext.UserRoles
                          on user.Id equals userRole.UserId
                          where userRole.RoleId == 2
                          select user)
                        .ToList();

            return View(values);
        }

        public IActionResult DeleteSinger(int id)
        {
            _singerService.TDelete(id);
            return RedirectToAction("Index");   
        }

        [HttpGet]
        public IActionResult CreateSinger()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSinger(Singer p)
        {
            var validator = new SingerValidator();
            ModelState.Clear();
            var result = validator.Validate(p);
            if (result.IsValid)
            {
				_singerService.TCreate(p);
				return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);

                }
                return View();
            }
        }


        [HttpGet]
        public IActionResult UpdateSinger(int id)
        {
            var values = _singerService.TGetById(id);
            return View(values);    
        }

        [HttpPost]
        public IActionResult UpdateSinger(Singer p)
        {
            _singerService.TUpdate(p);
            return RedirectToAction("Index");
        }

    }

}
