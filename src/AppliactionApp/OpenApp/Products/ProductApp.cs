using AppliactionApp.Interface.Products;
using Domain.Interface.Interfaces.Products;
using Domain.Interface.InterfaceServices.Products;
using Entity.Entities.ProductEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppliactionApp.OpenApp.Products
{
    public class ProductApp : IProductApp
    {
        //Injeção de dependencia
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;


        //=======Construtores=============
        public ProductApp(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }

        //======================Métodos=========================

        //=======Métodos CRUD===========================
        public async Task Add(Product Object)
        {
            await _IProduct.Add(Object);
        }

        public async Task Update(Product Object)
        {
            await _IProduct.UpDate(Object);
        }

        public async Task Delete(Product Object)
        {
            await _IProduct.Delete(Object);
        }

        //Método para pesquisa==========================
        public async Task<Product> GetEntityById(int Id)
        {
            return await _IProduct.getEntityById(Id);
        }

        public async Task<List<Product>> List()
        {
            return await _IProduct.List();
        }


        //========Métodos custumizados==================
        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }
    }
}
