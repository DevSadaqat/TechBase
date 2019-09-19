namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientDocumentsEventLog")]
    public partial class tblPatientDocumentsEventLog
    {
        [Key]
        [Column(Order = 0)]
        public int tblPatientDocumentsEventLogID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int tblPatientDocumentsID { get; set; }

        public short EventCode { get; set; }

        public int UserPracticeCode { get; set; }

        public DateTime EventDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(512)]
        public string Notes { get; set; }
    }
}
