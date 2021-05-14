using Entity.Entities.ProductEntity;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices.Products
{
    public interface IServiceProduct
    {
        Task AddProduct(Product product);

        Task UpdateProduct(Product product);
    }
}
