using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_WPFDemo
{
    //Created on 30/Oct/2020 by Pankaj Patil for CG Internals
    public class DonorContext:DbContext
    {
        public DonorContext():base()
        {

        }
        public DonorContext(string conStr):base(conStr)
        {

        }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
