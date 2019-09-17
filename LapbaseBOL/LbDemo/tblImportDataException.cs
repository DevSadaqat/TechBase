namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("ETL.tblImportDataException")]
    public partial class tblImportDataException
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ImportFileName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string PatientName { get; set; }

        public int? ErrorCode { get; set; }

        public int? ErrorColumn { get; set; }

        [StringLength(2048)]
        public string ErrorDescription { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string CreatedBy { get; set; }
    }
}
