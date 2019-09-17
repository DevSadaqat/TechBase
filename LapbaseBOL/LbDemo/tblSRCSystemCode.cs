namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblSRCSystemCode")]
    public partial class tblSRCSystemCode
    {
        [Key]
        public int SRCSystemCodeID { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(10)]
        public string SRCCode { get; set; }

        [StringLength(10)]
        public string LapbaseCode { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
