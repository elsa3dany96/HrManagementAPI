using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.Models
{
    public class Ponus
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string EmployeeIDPerson { get; set; }
        public Employee Employee { get; set; }
        public double PonusCost { get; set; }
        public string Reason { get; set; }
        public string? extraTimeId { get; set; }
        public ExtraTime? ExtraTime { get; set; }
    }
}
