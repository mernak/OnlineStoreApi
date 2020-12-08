using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Entities;
using StoreApi.Interfaces;
using StoreAPI.Models;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody]OrderEntity order)
        {
            var entity = await _orderService.PostOrderAsync(order);
            return CreatedAtAction(
                "GetOrders",
                new { id = order.Id },
                entity
                );

        }
    }
}