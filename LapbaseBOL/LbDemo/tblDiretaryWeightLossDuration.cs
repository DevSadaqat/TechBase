namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblDiretaryWeightLossDuration")]
    public partial class tblDiretaryWeightLossDuration
    {
        [Key]
        public int DietaryWeightLossDurationID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
