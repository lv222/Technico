using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models
{
    public class PropertyRepair
    {
        public DateTime RepairDate { get; set; } = DateTime.Now;
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public string Cost { get; set; } = string.Empty;
        public PropertyOwner? PropertyOwner {get; set;}



    }
}
}
