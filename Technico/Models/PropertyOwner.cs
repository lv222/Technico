using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models
{
    public class PropertyOwner
    {
        public long Id { get; set; }
        public string VAT { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty; 
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserType { get; set; }  = string.Empty;
        public List<PropertyItem> PropertyItems { get; set; } = [];

    }
}
