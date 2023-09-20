namespace AgrowFarmProject.Services.VideoBanner
{
	public interface IVideoBannerService
	{
		Task<List<Models.VideoBanner>> GetAllVideoBanner();
		Task<Models.VideoBanner> GetByIdVideoBanner(string id);
		Task CreateVideoBanner(Models.VideoBanner videoBanner);
		Task UpdateVideoBanner(Models.VideoBanner videoBanner);
		Task DeleteVideoBanner(string id);
	}
}
