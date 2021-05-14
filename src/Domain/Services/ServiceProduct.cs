﻿using Domain.Interface.Interfaces.Products;
using Domain.Interface.InterfaceServices.Products;
using Entity.Entities.ProductEntity;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        //Injeção de dependencia
        private readonly IProduct _IProduct;

        //Construtor
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }


        //M=etodos 
        public async Task AddProduct(Product product)
        {
            var validateName = product.ValidateStringProperties(product.Name, "Name");
            var validateValue = product.ValidateDecimaProperties(product.Value, "Value");

            if (validateName && validateValue)
            {
                product.State = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validateName = product.ValidateStringProperties(product.Name, "Name");
            var validateValue = product.ValidateDecimaProperties(product.Value, "Value");

            if (validateName && validateValue)
            {
                await _IProduct.UpDate(product);
            }
        }
    }
}
