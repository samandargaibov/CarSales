using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesManagementDAL.Entities
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class TimeStample : SoftDelete
    {
        public string? CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public string? UpdatedBy { get; set; }
        
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }

    public class SoftDelete : Entity
    {
        public bool IsDeleted { get; set; }
    }
}
