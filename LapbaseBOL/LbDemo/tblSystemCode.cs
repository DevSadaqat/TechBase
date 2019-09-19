namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblSystemCode
    {
        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(10)]
        public string BoldCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CategoryCode { get; set; }

        [StringLength(2)]
        public string Score { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Description2 { get; set; }

        public int? Rank { get; set; }
    }
}
