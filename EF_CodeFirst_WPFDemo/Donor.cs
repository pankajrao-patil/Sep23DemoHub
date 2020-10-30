using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_WPFDemo
{
  public class Donor
    {
        public int DonorID { get; set; }
        public string Name { get; set; }
        public string BloodGrp { get; set; }
        public string City { get; set; }
    }
}
