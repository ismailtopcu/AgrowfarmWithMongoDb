using AgrowFarmProject.Services.OurService;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _OurServicePartial : ViewComponent
	{
		private readonly IOurServiceService _ourServiceService;

		public _OurServicePartial(IOurServiceService ourServiceService)
		{
			_ourServiceService = ourServiceService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _ourServiceService.GetAllOurService();
			return View(values);
		}
	}
}
