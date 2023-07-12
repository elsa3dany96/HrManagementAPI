using HrManagement.Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Core.ViewModels
{
    public class VEmployee
    {
        [Required ]
        public string fingerprint { get; set; }
        [Required, MaxLength(100)]
        public string fristName { get; set; }
        [Required, MaxLength(100)]
        public string lastName { get; set; }
        [Required , MaxLength(14)]
        public string iDPerson { get; set; }
        [Required]
        public IFormFile IDImg { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string position { get; set; }
        [Required]
        public double salary { get; set; }
        public string? MasterIDPerson { get; set; } = "NoOne";

    }
}
