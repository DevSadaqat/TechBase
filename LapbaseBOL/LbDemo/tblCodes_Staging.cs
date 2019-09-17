namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblCodes_Staging
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string CategoryCode { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Field2 { get; set; }
    }
}
