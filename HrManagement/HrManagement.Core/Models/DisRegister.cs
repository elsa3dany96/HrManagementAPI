using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.Models
{
    public class DisRegister
    {
       
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string EmployeeIDPerson { get; set; }
        public  Employee Employee { get; set; }
        public DateTime DayId { get; set; }
        public Day Day { get; set; }
        public string? discountId { get; set; }
        public Discount? Discount { get; set; }
    }
}
