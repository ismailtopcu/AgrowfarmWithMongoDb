namespace AgrowFarmProject.Services.WhyUs
{
	public interface IWhyUsService
	{
		Task<List<Models.WhyUs>> GetAllWhyUs();
		Task<Models.WhyUs> GetByIdWhyUs(string id);
		Task CreateWhyUs(Models.WhyUs whyUs);
		Task UpdateWhyUs(Models.WhyUs whyUs);
		Task DeleteWhyUs(string id);
	}
}
