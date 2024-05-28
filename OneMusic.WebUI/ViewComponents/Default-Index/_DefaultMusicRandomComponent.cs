using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
    public class _DefaultMusicRandomComponent : ViewComponent
    {
        private readonly ISongService _songService;

        public _DefaultMusicRandomComponent(ISongService songService)
        {
            _songService = songService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _songService.TGetSongWithAlbum().OrderByDescending(x=> x.SongValue).Take(5).ToList(); // Tüm şarkıları al
            return View(values);
        }
    }
}
