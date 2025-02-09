﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ProductEntity> Products { get; set; }
    }
}
