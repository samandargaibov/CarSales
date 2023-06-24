using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesManagementDAL.Entities
{
    public class Car : TimeStample
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public Car()
        {

        }

        public Car(string name, float price, int brandId)
        {
            Name = name;
            Price = price;
            BrandId = brandId;
        }
    }
}
