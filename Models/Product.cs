﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual List<ProductDetails> ProductDetails { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }


    }
}
