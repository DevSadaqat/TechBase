namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblSystemCodes_BOLD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string BoldCode { get; set; }

        [Required]
        [StringLength(10)]
        public string GroupCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CategoryCode { get; set; }

        [StringLength(10)]
        public string SCode { get; set; }

        public int? Rank { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(10)]
        public string SRCComorbidityCode { get; set; }

        [StringLength(100)]
        public string SRCComorBidityText { get; set; }

        [StringLength(255)]
        public string RegistryDescription { get; set; }
    }
}
