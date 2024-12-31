using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models
{
    public class PropertyItem
    {
        public long Id { get; set; }
        public string PropertyIdentificationNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ConstructionYear { get; set; } = string.Empty;
        public string PropertyType { get; set; } = string.Empty;
        public string VAT { get; set; } = string.Empty;
    }
}
