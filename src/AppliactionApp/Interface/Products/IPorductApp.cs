using AppliactionApp.Interface.Generics;
using Entity.Entities.ProductEntity;
using System.Threading.Tasks;

namespace AppliactionApp.Interface.Products
{
    public interface IPorductApp : IGenericApp<Product>
    {

        Task AddProduct(Product product);

        Task UpdateProduct(Product product);
    }
}
