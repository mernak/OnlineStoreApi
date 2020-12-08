using StoreApi.Interfaces;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class ProdcutDetailsService : IProductDetailsService
    {
      
        public Task<List<ProductDetails>> GetProductsDetailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
