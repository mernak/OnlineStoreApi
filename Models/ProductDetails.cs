using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int ProductId { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}
