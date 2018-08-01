using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using EmployeeInsertApi.Models;

namespace EmployeeInsertApi.DAL
{
    public class EmployeeDAL
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Profile> col;

        public EmployeeDAL()
        {
            this.client = new MongoClient("mongodb://champ6803:www12345@clusteratsdev-shard-00-00-lxs0q.mongodb.net:27017,clusteratsdev-shard-00-01-lxs0q.mongodb.net:27017,clusteratsdev-shard-00-02-lxs0q.mongodb.net:27017/admin?ssl=true");
            this.db = client.GetDatabase("ats");
            this.col = this.db.GetCollection<Profile>("profile");
        }

        public async Task UpdateEmployee(Profile p)
        {
            var updoneresult = await this.col.UpdateOneAsync(
                                Builders<Profile>.Filter.Eq("email", p.email),
                                Builders<Profile>.Update.Set("location", p.location)
                                .Set("position",p.position)
                                .Set("salary",p.salary));
           
        }

        public async Task<Profile> GetProfile(string email)
        {
            var profile = await this.col.Find(x => x.email.Equals(email)).FirstAsync();
            return profile;
        }

    }
}