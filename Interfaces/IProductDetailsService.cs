using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Interfaces
{
    public interface IProductDetailsService
    {
        Task<List<ProductDetails>> GetProductsDetailsAsync();
    }
}
