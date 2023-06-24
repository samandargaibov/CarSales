using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesManagementDAL.Entities
{
    public class Brand : TimeStample
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<Car>? Cars { get; set; }

        public Brand()
        {

        }

        public Brand(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }
}
