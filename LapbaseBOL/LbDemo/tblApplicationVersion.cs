namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblApplicationVersion")]
    public partial class tblApplicationVersion
    {
        [Key]
        public decimal VersionNo { get; set; }

        [StringLength(100)]
        public string ApplicationURL { get; set; }

        public bool? Enabled { get; set; }
    }
}
