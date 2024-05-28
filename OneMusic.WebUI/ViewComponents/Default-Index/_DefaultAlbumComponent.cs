using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
    public class _DefaultAlbumComponent : ViewComponent
    {
        private readonly IAlbumService _albumService;

        public _DefaultAlbumComponent(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _albumService.TGetAlbumsWithArtist();
            return View(values);
        }
    }
}
