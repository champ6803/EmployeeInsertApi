using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EmployeeInsertApi.Models
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

    
        public async Task InsertEmployee(Profile p)
        {
            await this.col.InsertOneAsync(p);
        }

           public async Task<Profile> UpdateEmployee(Profile p)
        {
        //   var filter = Builders<Profile>.Filter.Eq(s => s.email, p.email);
        //   return  this.col.updateOne(filter,new Profile{location=p.location,position=p.position,salary=p.salary});

        var query = this.col.Find(x => x.email.Equals(p.email)).FirstAsync();
        query.location = p.location;
        query.salary = p.salary;
        query.position = p.position;

        var result = this.col.Save(query);
        return result;
        }

         public async Task<Profile> GetProfile(string email)
        {
            var profile = await this.col.Find(x => x.email.Equals(email)).FirstAsync();
            return profile;
        }

    }
}