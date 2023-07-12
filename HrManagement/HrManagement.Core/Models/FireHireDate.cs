using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.Models
{
    public class FireHireDate
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public bool Fired { get; set; }
        public string EmployeeIDPerson { get; set; }
        public Employee Employee { get; set; }

    }
}
