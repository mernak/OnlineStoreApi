using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();

        Task<List<Product>> GetProductByCategoryIdAsync(int Id);
        int GetProductsPrice(int id, int count);
    }
}
