using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingAgency.Models
{
    public class PriceModel : BaseModel
    {
        public float starting_price { get; set; }
        public DateTime duration { get; set; }
        public DateTime broadcast_time { get; set; }
        public float coefficient { get; set; }
    }
}
