using AgrowFarmProject.Settings;
using MongoDB.Driver;

namespace AgrowFarmProject.Services.Statistic
{
	public class StatisticService : IStatisticService
	{
		private readonly IMongoCollection<Models.Statistic> _statisticCollection;
		public StatisticService(IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_statisticCollection = database.GetCollection<Models.Statistic>(_databaseSettings.StatisticCollectionName);
		}
		public async Task CreateStatistic(Models.Statistic statistic)
		{
			await _statisticCollection.InsertOneAsync(statistic);
		}

		public async Task DeleteStatistic(string id)
		{
			var values = await _statisticCollection.DeleteOneAsync(x => x.StatisticId == id);
		}

		public async Task<List<Models.Statistic>> GetAllStatistic()
		{
			var values = await _statisticCollection.Find(x => true).ToListAsync();
			return values;
		}

		public async Task<Models.Statistic> GetByIdStatistic(string id)
		{
			var value = await _statisticCollection.Find<Models.Statistic>(x => x.StatisticId == id).FirstOrDefaultAsync();
			return value;
		}

		public async Task UpdateStatistic(Models.Statistic statistic)
		{
			var result = await _statisticCollection.FindOneAndReplaceAsync(x => x.StatisticId == statistic.StatisticId, statistic);
		}
	}
}
