using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;
using X.PagedList;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
   
    public class _DefaultAlbumSongChangeComponent : ViewComponent
    {
        private readonly IAlbumService _albumService;

        public _DefaultAlbumSongChangeComponent(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IViewComponentResult Invoke(int p = 1)
        {
            var values = _albumService.TGetAlbumsWithArtist().ToPagedList(p,4);
            return View(values);
        }
    }
}
