using AgrowFarmProject.Models;
using AgrowFarmProject.Services.About;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminAboutController : Controller
	{
		private readonly IAboutService _aboutService;

		public AdminAboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IActionResult Index()
		{
			var values = _aboutService.GetAllAbout();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{
			
			return View();

		}[HttpPost]
		public IActionResult Create(About about)
		{
			_aboutService.CreateAbout(about);
			return View();
		}
	}
}
