using AgrowFarmProject.Settings;
using MongoDB.Driver;

namespace AgrowFarmProject.Services.OurService
{
	public class OurServiceService : IOurServiceService
	{
		private readonly IMongoCollection<Models.OurService> _ourServiceCollection;
		public OurServiceService(IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_ourServiceCollection = database.GetCollection<Models.OurService>(_databaseSettings.OurServiceCollectionName);
		}
		public async Task CreateOurService(Models.OurService ourService)
		{
			await _ourServiceCollection.InsertOneAsync(ourService);
		}

		public async Task DeleteOurService(string id)
		{
			var values = await _ourServiceCollection.DeleteOneAsync(x => x.OurServiceId == id);
		}

		public async Task<List<Models.OurService>> GetAllOurService()
		{
			var values = await _ourServiceCollection.Find(x => true).ToListAsync();
			return values;
		}

		public async Task<Models.OurService> GetByIdOurService(string id)
		{
			var value = await _ourServiceCollection.Find<Models.OurService>(x => x.OurServiceId == id).FirstOrDefaultAsync();
			return value;
		}

		public async Task UpdateOurService(Models.OurService ourService)
		{
			var result = await _ourServiceCollection.FindOneAndReplaceAsync(x => x.OurServiceId == ourService.OurServiceId, ourService);
		}
	}
}
