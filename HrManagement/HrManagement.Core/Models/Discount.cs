using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.Models
{
    public class Discount
    {
        
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string EmployeeIDPerson { get; set; }
        public Employee Employee { get; set; }
        public double DiscountCost { get; set; }
        public string Reason { get; set; }
        public string? comeLateId { get; set; }
        public ComeLate? ComeLate { get; set; }
        public string? disAttendId { get; set; }
        public Disattend? disAttend { get; set; }
        public string? disRegisterId { get; set; }
        public DisRegister? disRegister { get; set; }
        public string? wentEarlyId { get; set; }
        public WentEarly? wentEarly { get; set; }

    }
}
