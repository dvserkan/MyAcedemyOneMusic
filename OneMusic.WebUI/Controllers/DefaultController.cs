using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.EntityLayer.Entities;

namespace OneMusic.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IAlbumService _albumService;

        public DefaultController(IMessageService messageService, IAlbumService albumService)
        {
            _messageService = messageService;
            _albumService = albumService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message p )
        {
           
            _messageService.TCreate(p);
            return NoContent();
        }


    }
}
