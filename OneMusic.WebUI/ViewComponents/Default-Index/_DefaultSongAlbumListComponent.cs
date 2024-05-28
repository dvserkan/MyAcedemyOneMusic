using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
    public class _DefaultSongAlbumListComponent : ViewComponent
    {
        private readonly ISongService _songService;

        public _DefaultSongAlbumListComponent(ISongService songService)
        {
            _songService = songService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _songService.TGetSongWithAlbum().OrderByDescending(x=> x.SongValue).Take(4).ToList();
            return View(values);
        }
    }
}
