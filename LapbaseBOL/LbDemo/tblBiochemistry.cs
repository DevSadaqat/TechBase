namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblBiochemistry")]
    public partial class tblBiochemistry
    {
        [Key]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int? Rank { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int? BiochemistryGroup { get; set; }
    }
}
