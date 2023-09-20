using AgrowFarmProject.Models;
using AgrowFarmProject.Services.Statistic;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.Controllers
{
	public class AdminStatisticController : Controller
	{
		private readonly IStatisticService _statisticService;

		public AdminStatisticController(IStatisticService statisticService)
		{
			_statisticService = statisticService;
		}

		public IActionResult Index()
		{
			var values = _statisticService.GetAllStatistic();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create()
		{

			return View();

		}
		[HttpPost]
		public IActionResult Create(Statistic statistic)
		{
			_statisticService.CreateStatistic(statistic);
			return View();
		}
	}
}
