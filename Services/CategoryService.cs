using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StoreApi.Database;
using StoreApi.Interfaces;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly StoreDBContext _context;
        private readonly IMapper _mapper;
        public CategoryService(StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            if (categories == null)
            {
                return null;
            }
            return _mapper.Map<List<Category>>(categories);
        }

       
    }
}
