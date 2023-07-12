using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.Models
{
    public class Day
    {
        
        public DateTime Id { get; set; }= DateTime.Now;
        public DateTime? Attend { get; set; }
        public DateTime? Went { get; set; }
        public string? comeLateId { get; set; }
        public ComeLate? ComeLate { get; set; }
        public string? disAttendId { get; set; }
        public Disattend? Disattend { get; set; }
        public string? disRegisterId { get; set; }
        public DisRegister? DisRegister { get; set; }
        public string? extraTimeId { get; set; }
        public ExtraTime? ExtraTime { get; set; }
        public string? wentEarlyId { get; set; }
        public WentEarly? WentEarly { get; set; }



    }
}
