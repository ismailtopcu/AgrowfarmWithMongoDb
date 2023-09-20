using AgrowFarmProject.Settings;
using MongoDB.Driver;

namespace AgrowFarmProject.Services.Banner
{
	public class BannerService : IBannerService
	{
		private readonly IMongoCollection<Models.Banner> _bannerCollection;
		public BannerService(IDatabaseSettings _databaseSettings)
		{
			var client = new MongoClient(_databaseSettings.ConnectionString);
			var database = client.GetDatabase(_databaseSettings.DatabaseName);
			_bannerCollection = database.GetCollection<Models.Banner>(_databaseSettings.BannerCollectionName);
		}
		public async Task CreateBanner(Models.Banner banner)
		{
			await _bannerCollection.InsertOneAsync(banner);
		}

		public async Task DeleteBanner(string id)
		{
			var values = await _bannerCollection.DeleteOneAsync(x => x.BannerId == id);
		}

		public async Task<List<Models.Banner>> GetAllBanner()
		{
			var values = await _bannerCollection.Find(x => true).ToListAsync();
			return values;
		}

		public async Task<Models.Banner> GetByIdBanner(string id)
		{
			var value = await _bannerCollection.Find<Models.Banner>(x => x.BannerId == id).FirstOrDefaultAsync();
			return value;
		}

		public async Task UpdateBanner(Models.Banner banner)
		{
			var result = await _bannerCollection.FindOneAndReplaceAsync(x => x.BannerId == banner.BannerId, banner);
		}
	}
}
