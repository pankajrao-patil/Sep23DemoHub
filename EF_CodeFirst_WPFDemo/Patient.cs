using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_WPFDemo
{
  public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
