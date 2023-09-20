using AgrowFarmProject.Settings;
using MongoDB.Driver;

namespace AgrowFarmProject.Services.WhyUs
{
	public class WhyUsService : IWhyUsService
	{
		private readonly IMongoCollection<Models.WhyUs> _whyUsCollection;
		public WhyUsService(IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_whyUsCollection = database.GetCollection<Models.WhyUs>(_databaseSettings.WhyUsCollectionName);
		}
		public async Task CreateWhyUs(Models.WhyUs whyUs)
		{
			await _whyUsCollection.InsertOneAsync(whyUs);
		}

		public async Task DeleteWhyUs(string id)
		{
			var values = await _whyUsCollection.DeleteOneAsync(x => x.WhyUsId == id);
		}

		public async Task<List<Models.WhyUs>> GetAllWhyUs()
		{
			var values = await _whyUsCollection.Find(x => true).ToListAsync();
			return values;
		}

		public async Task<Models.WhyUs> GetByIdWhyUs(string id)
		{
			var value = await _whyUsCollection.Find<Models.WhyUs>(x => x.WhyUsId == id).FirstOrDefaultAsync();
			return value;
		}

		public async Task UpdateWhyUs(Models.WhyUs whyUs)
		{
			var result = await _whyUsCollection.FindOneAndReplaceAsync(x => x.WhyUsId == whyUs.WhyUsId, whyUs);
		}
	}
}
