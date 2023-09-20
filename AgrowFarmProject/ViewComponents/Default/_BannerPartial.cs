using AgrowFarmProject.Services.Banner;
using AgrowFarmProject.Services.WhyUs;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _BannerPartial : ViewComponent
	{
		private readonly IBannerService _bannerService;

		public _BannerPartial(IBannerService bannerService)
		{
			_bannerService = bannerService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _bannerService.GetAllBanner();
			return View(values);
		}
	}
}
