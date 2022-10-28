using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingAgency.Models
{
    public class WorkingOnAPlanModel : BaseModel
    {
        public int staff_id { get; set; }
        public int media_plan_id { get; set; }
        public bool status { get; set; }
        public string specification { get; set; }
    }
}
