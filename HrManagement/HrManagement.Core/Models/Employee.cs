using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.Models
{
    public class Employee
    {
        public string IDPerson { get; set; }
        public string fingerprint { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }       
        public byte[] IDImg { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public bool InService { get; set; } = true;
        public string Position { get; set; }
        public double Salary { get; set; }
        public string MasterIDPerson { get; set; } = "NoOne";
        public bool stopRegister { get; set; }
        public ICollection<Discount> Discount { get; set; } = new List<Discount>();
        public ICollection<Ponus> Ponus { get; set; } = new List<Ponus>();
        public ICollection<WentEarly> WentEarly { get; set; } = new List<WentEarly>();
        public ICollection<ComeLate> ComeLate { get; set; } = new List<ComeLate>();
        public ICollection<DisRegister> DisRegister { get; set; } = new List<DisRegister>();
        public ICollection<Disattend> Disattend { get; set; } = new List<Disattend>();
        public ICollection<ExtraTime> ExtraTime { get; set; } = new List<ExtraTime>();
        public ICollection<FireHireDate> FireHireDate { get; set; } = new List<FireHireDate>();
        public ICollection<Day> Days { get; set; } = new List<Day>();

    }
}
