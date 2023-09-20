using AgrowFarmProject.Services.VideoBanner;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _VideoBannerPartial : ViewComponent
	{
		private readonly IVideoBannerService _videoBannerService;

		public _VideoBannerPartial(IVideoBannerService videoBannerService)
		{
			_videoBannerService = videoBannerService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _videoBannerService.GetAllVideoBanner();
			return View(values);
		}
	}
}
