namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblUsysUserObjectLog
    {
        [Key]
        public int tblUsysUserObjectLogs_SNo { get; set; }

        [StringLength(50)]
        public string ComputerName { get; set; }

        public int UserPracticeCode { get; set; }

        [StringLength(50)]
        public string SystemUsername { get; set; }

        [StringLength(50)]
        public string AccessUsername { get; set; }

        [StringLength(255)]
        public string ObjectName { get; set; }

        public byte? ObjectType { get; set; }

        [StringLength(255)]
        public string ActionName { get; set; }

        [StringLength(255)]
        public string SchemaName { get; set; }

        [StringLength(255)]
        public string SchemaCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? OpenTime { get; set; }
    }
}
