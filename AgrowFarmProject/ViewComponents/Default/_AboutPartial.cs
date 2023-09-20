using AgrowFarmProject.Services.About;
using Microsoft.AspNetCore.Mvc;

namespace AgrowFarmProject.ViewComponents.Default
{
	public class _AboutPartial : ViewComponent
	{
		private readonly IAboutService _aboutService;

		public _AboutPartial(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values =await _aboutService.GetAllAbout();
			return View(values);
		}
	}
}
