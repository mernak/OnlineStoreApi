using AutoMapper;
using StoreApi.Database;
using StoreApi.Entities;
using StoreApi.Interfaces;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly StoreDBContext _context;
        private readonly IMapper _mapper;
        public OrderService(StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<Order>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> PostOrderAsync(OrderEntity order)
        {
            order.OrderDate = DateTime.Today;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return _mapper.Map<Order>(order);
        }

    }
}
