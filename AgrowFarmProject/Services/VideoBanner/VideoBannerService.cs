using AgrowFarmProject.Settings;
using MongoDB.Driver;

namespace AgrowFarmProject.Services.VideoBanner
{
	public class VideoBannerService : IVideoBannerService
	{
		private readonly IMongoCollection<Models.VideoBanner> _videoBannerCollection;
		public VideoBannerService(IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_videoBannerCollection = database.GetCollection<Models.VideoBanner>(_databaseSettings.VideoBannerCollectionName);
		}
		public async Task CreateVideoBanner(Models.VideoBanner videoBanner)
		{
			await _videoBannerCollection.InsertOneAsync(videoBanner);
		}

		public async Task DeleteVideoBanner(string id)
		{
			var values = await _videoBannerCollection.DeleteOneAsync(x => x.VideoBannerId == id);
		}

		public async Task<List<Models.VideoBanner>> GetAllVideoBanner()
		{
			var values = await _videoBannerCollection.Find(x => true).ToListAsync();
			return values;
		}

		public async Task<Models.VideoBanner> GetByIdVideoBanner(string id)
		{
			var value = await _videoBannerCollection.Find<Models.VideoBanner>(x => x.VideoBannerId == id).FirstOrDefaultAsync();
			return value;
		}

		public async Task UpdateVideoBanner(Models.VideoBanner videoBanner)
		{
			var result = await _videoBannerCollection.FindOneAndReplaceAsync(x => x.VideoBannerId == videoBanner.VideoBannerId, videoBanner);
		}
	}
}
