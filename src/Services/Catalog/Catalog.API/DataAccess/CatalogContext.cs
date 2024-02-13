using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.DataAccess
{
    public class CatalogContext : ICatalogContext
    {

        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DataBaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DataBaseSettings:DataBaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DataBaseSettings:CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
