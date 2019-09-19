namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientDocumentsContent")]
    public partial class tblPatientDocumentsContent
    {
        [Key]
        [Column(Order = 0)]
        public int tblPatientDocumentsContentID { get; set; }

        public int tblPatientDocumentsID { get; set; }

        [Column(TypeName = "image")]
        public byte[] ContentFile { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }
    }
}
