using AgrowFarmProject.Models;

namespace AgrowFarmProject.Services.About
{
	public interface IAboutService 
	{
		Task<List<Models.About>> GetAllAbout();
		Task<Models.About> GetByIdAbout(string id);
		Task CreateAbout(Models.About about);
		Task UpdateAbout(Models.About about);
		Task DeleteAbout(string id);
	}
}
