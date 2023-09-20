namespace AgrowFarmProject.Services.Statistic
{
	public interface IStatisticService
	{
		Task<List<Models.Statistic>> GetAllStatistic();
		Task<Models.Statistic> GetByIdStatistic(string id);
		Task CreateStatistic(Models.Statistic statistic);
		Task UpdateStatistic(Models.Statistic statistic);
		Task DeleteStatistic(string id);
	}
}
