namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblAppSchema")]
    public partial class tblAppSchema
    {
        [Key]
        public int tblAPPSCHEMA_CODE { get; set; }

        [StringLength(100)]
        public string APPSCHEMA_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string SCHEMA_TYPE { get; set; }
    }
}
