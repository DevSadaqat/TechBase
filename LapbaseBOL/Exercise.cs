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
        public string ExerciseName { get; set; }

        public decimal? Duration { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] StartTime { get; set; }

        public long PatientID { get; set; }

        public long OrganizationCode { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual ExerciseItem ExerciseItem { get; set; }
    }
}
