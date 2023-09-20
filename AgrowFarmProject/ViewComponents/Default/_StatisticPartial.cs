using AgrowFarmProject.Services.Statistic;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _StatisticPartial : ViewComponent
	{
		private readonly IStatisticService _statisticService;

		public _StatisticPartial(IStatisticService statisticService)
		{
			_statisticService = statisticService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _statisticService.GetAllStatistic();
			return View(values);
		}
	}
}
