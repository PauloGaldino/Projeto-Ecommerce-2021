using Domain.Interface.Interfaces.Products;
using Entity.Entities.ProductEntity;
using Infrastructure.Reposiory.Generics;

namespace Infrastructure.Reposiory.Repositories.Products
{
    public class ProductRepository : GenericRepository<Product>, IProduct
    {
    }
}
