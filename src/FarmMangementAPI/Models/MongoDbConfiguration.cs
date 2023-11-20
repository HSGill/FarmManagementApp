namespace FarmManagementApp.Models
{
    public class MongoDbConfiguration
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public bool UseSsl { get; set; } 

        public string CollectionName { get; set; }
    }

}
