using FarmManagementApp.Models;
using MongoDB.Driver;

namespace FarmManagementApp.Data
{
    public class FarmRepository
    {
        private readonly IMongoCollection<Farm> _farms;

        public FarmRepository(MongoDbContext context)
        {
            _farms = context.Farms;
        }

        public IEnumerable<Farm> GetFarms()
        {
            return _farms.Find(f => true).ToList();
        }
    }

}
