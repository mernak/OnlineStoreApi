using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreApi.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<ProductDetailsEntity> ProductDetails { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual CategoryEntity Category { get; set; }
    }
}
