using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StoreApi.Entities;
using StoreAPI.Models;

namespace StoreApi.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryEntity, Category>();
            CreateMap<DepartmentEntity, Department>();
            CreateMap<OrderEntity, Order>();
            CreateMap<ProductEntity, Product>();
            CreateMap<ProductDetailsEntity, ProductDetails>();
        }
    }
}
