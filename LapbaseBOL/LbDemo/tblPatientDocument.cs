namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientDocument
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public int tblPatientDocumentsID { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientID { get; set; }

        [StringLength(1)]
        public string EventLink { get; set; }

        public long EventID { get; set; }

        public DateTime? EventDate { get; set; }

        public short DocumentType { get; set; }

        [StringLength(100)]
        public string DocumentFileName { get; set; }

        [StringLength(50)]
        public string DocumentName { get; set; }

        public long? DocumentFileSize { get; set; }

        public DateTime? UploadDate { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(1024)]
        public string Doc_Description { get; set; }
    }
}
