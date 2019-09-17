namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblActionLog")]
    public partial class tblActionLog
    {
        public int tblActionLogID { get; set; }

        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [StringLength(255)]
        public string ComputerName { get; set; }

        [StringLength(255)]
        public string Page { get; set; }

        [StringLength(255)]
        public string Action { get; set; }

        [StringLength(255)]
        public string ActionDetail { get; set; }

        [StringLength(255)]
        public string PatientID { get; set; }

        [StringLength(255)]
        public string RecordID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateTime { get; set; }
    }
}
