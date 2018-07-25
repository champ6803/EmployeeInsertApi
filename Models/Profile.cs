using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EmployeeInsertApi.Models
{
    public class Profile
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string email { get; set; }
        public string user { get; set; }
        public string pwd { get; set; }
        public string type_account { get; set; }
    }
}