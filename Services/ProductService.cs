using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class ProductService : IProductService
    {
        private readonly StoreDBContext _context;
        private readonly IMapper _mapper;
        public ProductService(StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Product>> GetProductByCategoryIdAsync(int Id)
        {
            var products = await _context.Products.Where(p => p.CategoryId == Id).Include(p => p.ProductDetails.OrderBy(d => d.ReceivedDate)).ToListAsync();
            if (products == null)
            {
                return null;
            }
            return _mapper.Map<List<Product>>(products);
        }

        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }


        public  int GetProductsPrice(int id, int count)
        {
            var products =  _context.Products.Where(p => p.Id == id).Include(p => p.ProductDetails.OrderBy(d => d.ReceivedDate)).ToList();
         
            int totalPrice = 0;
            int qtyCounter = 0;
            int counter = 0;

            int qty = count;
            foreach (ProductEntity prod in products)
            {
                for (int i =0; i < prod.ProductDetails.Count ; i++){
                    qtyCounter = prod.ProductDetails[i].Qty;
                    while(qtyCounter != 0 && counter != count)
                    {
                        totalPrice += (int) prod.ProductDetails[i].UnitPrice;

                        qtyCounter--;
                        counter++;
                    }

                }
       
            }
            return totalPrice;

        }
    }
}
