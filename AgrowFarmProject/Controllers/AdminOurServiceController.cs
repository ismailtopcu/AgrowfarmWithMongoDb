using AgrowFarmProject.Models;
using AgrowFarmProject.Services.OurService;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminOurServiceController : Controller
	{
		private readonly IOurServiceService _ourServiceService;

		public AdminOurServiceController(IOurServiceService ourServiceService)
		{
			_ourServiceService = ourServiceService;
		}

		public IActionResult Index()
		{
			var values = _ourServiceService.GetAllOurService();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();

		}
		[HttpPost]
		public IActionResult Create(OurService ourService)
		{
			_ourServiceService.CreateOurService(ourService);
			return View();
		}
	}
}
