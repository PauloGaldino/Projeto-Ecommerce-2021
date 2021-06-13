using AppliactionApp.Interface.Generics;
using Entity.Entities.ProductEntity;
using System.Threading.Tasks;

namespace AppliactionApp.Interface.Products
{
    public interface IProductApp : IGenericApp<Product>
    {
        //========Métodos custumizados========

        Task AddProduct(Product product);

        Task UpdateProduct(Product product);
    }
}
