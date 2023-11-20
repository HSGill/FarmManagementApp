using FarmManagementApp.Models;
using MongoDB.Driver;

namespace FarmManagementApp.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(MongoDbConfiguration config)
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl(config.ConnectionString));
            if (config.UseSsl)
            {
                settings.UseSsl = true;
            }

            var client = new MongoClient(settings);
            _database = client.GetDatabase(config.DatabaseName);
        }

        public IMongoCollection<Farm> Farms => _database.GetCollection<Farm>("farms");
    }


}
