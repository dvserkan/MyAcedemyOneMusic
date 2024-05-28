using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.EntityLayer.Entities;

namespace OneMusic.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }


        public IActionResult DeleteContact(int id)
        {
            _contactService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact p)
        {
            _contactService.TCreate(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = _contactService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact p)
        {
            _contactService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
