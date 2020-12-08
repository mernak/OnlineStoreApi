using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Database;
using StoreApi.Entities;
using StoreApi.Interfaces;
using StoreApi.Services;
using StoreAPI.Models;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly  IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _departmentService.GetDepartmentsAsync();
            if (departments == null)
            {
                return NotFound();
            }
            return Ok(departments);
        }

        [HttpPost]
        public async Task<ActionResult<Department>> Post([FromBody]DepartmentEntity department)
        {
            var entity = await _departmentService.PostDepartmentAsync(department);
            return CreatedAtAction(
                "GetDepartments",
                new { id = department.Id },
                entity
                );

        }
    }
}