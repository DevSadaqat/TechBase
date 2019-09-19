namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblErrorLogFile")]
    public partial class tblErrorLogFile
    {
        public int tblErrorLogFileID { get; set; }

        public DateTime logDateTime { get; set; }

        public int UserPracticeCode { get; set; }

        public int UserCode { get; set; }

        [StringLength(15)]
        public string ClientIP { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string SchemaName { get; set; }

        [StringLength(255)]
        public string ProcessName { get; set; }

        [Column(TypeName = "text")]
        public string ErrorMessage { get; set; }
    }
}
