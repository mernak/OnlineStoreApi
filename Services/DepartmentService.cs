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
    public class DepartmentService : IDepartmentService
    {
        private readonly StoreDBContext _context;
        private readonly IMapper _mapper;
        public DepartmentService(StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Department>> GetDepartmentsAsync()
        {
            var departments = await _context.Departments.ToListAsync();
            if (departments == null)
            {
                return null;
            }
            return _mapper.Map<List<Department>>(departments);
        }

        public async Task<Department> PostDepartmentAsync(DepartmentEntity Department)
        {
            _context.Departments.Add(Department);
            await _context.SaveChangesAsync();
            return _mapper.Map<Department>(Department);
        }
    }
}
