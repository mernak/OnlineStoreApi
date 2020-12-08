using StoreApi.Entities;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersAsync();

        Task<Order> PostOrderAsync(OrderEntity order);
    }
}
