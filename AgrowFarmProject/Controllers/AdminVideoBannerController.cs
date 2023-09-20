using AgrowFarmProject.Models;
using AgrowFarmProject.Services.VideoBanner;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminVideoBannerController : Controller
	{
		private readonly IVideoBannerService _videoBannerService;

		public AdminVideoBannerController(IVideoBannerService videoBannerService)
		{
			_videoBannerService = videoBannerService;
		}

		public IActionResult Index()
		{
			var values = _videoBannerService.GetAllVideoBanner();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();

		}
		[HttpPost]
		public IActionResult Create(VideoBanner videoBanner)
		{
			_videoBannerService.CreateVideoBanner(videoBanner);
			return View();
		}
	}
}
