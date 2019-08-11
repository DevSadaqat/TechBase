using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LapbaseBOL
{    
    [Table("lbd.Exercise")]
    public class Exercise : BaseClass
    { 
        public long ID { get; set; }

        [StringLength(30)]
        public string ExerciseType { get; set; }

        public decimal? Duration { get; set; }

        public long PatientID { get; set; }

        public long OrganizationCode { get; set; }

        public virtual Patient Patient { get; set; }

    
    }
}
