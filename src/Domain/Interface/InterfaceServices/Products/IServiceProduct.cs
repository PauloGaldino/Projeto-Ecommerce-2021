using Entity.Entities.ProductEntity;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices.Products
{
    public interface IServiceProduct
    {
        //============Métodos custumizados=======

        Task AddProduct(Product product);

        Task UpdateProduct(Product product);
    }
}
