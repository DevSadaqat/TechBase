namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("ETL.tblImportDataLog")]
    public partial class tblImportDataLog
    {
        public long ID { get; set; }

        [StringLength(255)]
        public string InputFileName { get; set; }

        public int? OrganizationCode { get; set; }

        public int? UserPracticeCode { get; set; }

        public int? TotalRows { get; set; }

        public int? ImportedRows { get; set; }

        public int? ExceptionRows { get; set; }

        public DateTime? ImportDate { get; set; }
    }
}
