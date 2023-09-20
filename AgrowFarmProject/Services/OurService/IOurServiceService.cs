namespace AgrowFarmProject.Services.OurService
{
	public interface IOurServiceService
	{
		Task<List<Models.OurService>> GetAllOurService();
		Task<Models.OurService> GetByIdOurService(string id);
		Task CreateOurService(Models.OurService ourService);
		Task UpdateOurService(Models.OurService ourService);
		Task DeleteOurService(string id);
	}
}
