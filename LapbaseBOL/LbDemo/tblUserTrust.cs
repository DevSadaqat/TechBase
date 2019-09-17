namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblUserTrust")]
    public partial class tblUserTrust
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblUserTrust_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int Trust_UserPracticeCode { get; set; }

        public int Trustee_UserPracticeCode { get; set; }

        public int PatientID { get; set; }

        public bool UsePatientTitle { get; set; }

        public bool UsePatientData { get; set; }

        public DateTime? FDate { get; set; }

        public DateTime? TDate { get; set; }

        public int AccessPermission { get; set; }

        [StringLength(512)]
        public string Remark { get; set; }
    }
}
