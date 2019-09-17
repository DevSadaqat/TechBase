namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblVersionLog")]
    public partial class tblVersionLog
    {
        [Key]
        public decimal Version { get; set; }

        [StringLength(50)]
        public string VersionNo { get; set; }

        [StringLength(2048)]
        public string ChangeLog { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public bool? Enabled { get; set; }
    }
}
