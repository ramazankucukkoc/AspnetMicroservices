using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.DataAccess
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
