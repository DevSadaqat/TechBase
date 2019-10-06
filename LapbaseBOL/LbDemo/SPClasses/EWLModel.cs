using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LapbaseBOL.LbDemo.SPClasses
{
    public class EWLModel
    {
        [Key]
        public int PatientId { get; set; }
        public string DateSeen_MY { get; set; }
        public decimal? EWL { get; set; }
    }
}
