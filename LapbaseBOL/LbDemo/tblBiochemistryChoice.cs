namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblBiochemistryChoice")]
    public partial class tblBiochemistryChoice
    {
        [Key]
        public int BiochemistryChoiceID { get; set; }

        [Required]
        [StringLength(50)]
        public string BiochemistryCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ChoiceCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ChoiceDescription { get; set; }

        public int? Rank { get; set; }
    }
}
