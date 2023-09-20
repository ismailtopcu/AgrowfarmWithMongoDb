﻿using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
	public class OurService
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string OurServiceId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Services { get; set; }
		public string ImageUrl { get; set; }
	}
}
