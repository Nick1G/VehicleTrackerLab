using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTrackerLab.Models
{
    public class Vehicle
    {
        public string Licence { get; set; }
        public bool Pass { get; set; }

        public Vehicle(string licence, bool pass)
        {
            this.Licence = licence;
            this.Pass = pass;
        }
    }
}
