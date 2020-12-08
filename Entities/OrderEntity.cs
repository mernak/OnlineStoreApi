using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreApi.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public int DepartmentId { get; set; }

        [JsonIgnore]
        public virtual DepartmentEntity Department { get; set; }

        public virtual List<ProductEntity> Products { get; set; }
    }
}
