using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
	public class Banner
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string BannerId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
    }
}
