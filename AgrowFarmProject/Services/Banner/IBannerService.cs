using AgrowFarmProject.Services.Banner;

namespace AgrowFarmProject.Services.Banner
{
	public interface IBannerService
	{
		Task<List<Models.Banner>> GetAllBanner();
		Task<Models.Banner> GetByIdBanner(string id);
		Task CreateBanner(Models.Banner banner);
		Task UpdateBanner(Models.Banner banner);
		Task DeleteBanner(string id);
	}
}
