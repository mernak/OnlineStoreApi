using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StoreApi.Entities
{
    public class ProductDetailsEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int ProductId { get; set; }

        [JsonIgnore]
        public virtual ProductEntity Product { get; set; }
    }
}
