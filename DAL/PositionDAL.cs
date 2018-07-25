using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EmployeeInsertApi.Models
{
    public class PositionDAL
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Position> col;

        public PositionDAL()
        {
            this.client = new MongoClient("mongodb://champ6803:www12345@clusteratsdev-shard-00-00-lxs0q.mongodb.net:27017,clusteratsdev-shard-00-01-lxs0q.mongodb.net:27017,clusteratsdev-shard-00-02-lxs0q.mongodb.net:27017/admin?ssl=true");
            this.db = client.GetDatabase("ats");
            this.col = this.db.GetCollection<Position>("position");
        }

        public async Task<IEnumerable<Position>> All()
        {
            var list = await this.col.Find(new BsonDocument()).ToListAsync();
            return list;
        }


    }
}