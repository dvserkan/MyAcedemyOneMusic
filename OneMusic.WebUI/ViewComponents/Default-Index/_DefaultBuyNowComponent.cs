using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.ViewComponents.Default_Index
{
	public class _DefaultBuyNowComponent : ViewComponent
	{
		private readonly IAlbumService _albumService;

		public _DefaultBuyNowComponent(IAlbumService albumService)
		{
			_albumService = albumService;
		}

		public IViewComponentResult Invoke()
		{
			
			var values = _albumService.TGetList();
			return View(values);
		}
	}
}
