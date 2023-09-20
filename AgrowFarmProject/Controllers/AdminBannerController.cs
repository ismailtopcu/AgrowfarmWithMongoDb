using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Banner;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminBannerController : Controller
	{
		private readonly IBannerService _bannerService;

		public AdminBannerController(IBannerService bannerService)
		{
			_bannerService = bannerService;
		}

		public IActionResult Index()
		{
			var values = _bannerService.GetAllBanner();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{
			
			return View();

		}[HttpPost]
		public IActionResult Create(Banner banner)
		{
			_bannerService.CreateBanner(banner);
			return View();
		}
	}
}
