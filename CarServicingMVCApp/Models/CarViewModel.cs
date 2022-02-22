using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarServicing.Models
{
    public class CarViewModel
    {
        public string RegistrationNumber { get; set; }
        public string Owner { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public string Service { get; set; }

    }
}