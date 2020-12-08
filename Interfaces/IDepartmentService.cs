using StoreApi.Entities;
using StoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Interfaces
{
   public interface IDepartmentService
    {
        Task<List<Department>> GetDepartmentsAsync();

        Task<Department> PostDepartmentAsync(DepartmentEntity Department);
    }
}
