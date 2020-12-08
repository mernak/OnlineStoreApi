using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public int DepartmentId { get; set; }

        [JsonIgnore]
        public virtual Department Department { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
