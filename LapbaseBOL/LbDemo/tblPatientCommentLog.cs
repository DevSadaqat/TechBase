namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientCommentLog")]
    public partial class tblPatientCommentLog
    {
        [Key]
        public int CommentLogID { get; set; }

        public int CommentID { get; set; }

        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [Column("Patient Id")]
        public int Patient_Id { get; set; }

        public DateTime? DateSeen { get; set; }

        public int Seenby { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(30)]
        public string CreatedByUser { get; set; }

        [StringLength(30)]
        public string CreatedByComputer { get; set; }

        public DateTime? LastModified { get; set; }

        [StringLength(30)]
        public string ModifiedByUser { get; set; }

        [StringLength(30)]
        public string ModifiedByComputer { get; set; }

        [StringLength(30)]
        public string CreatedByWindowsUser { get; set; }

        [StringLength(30)]
        public string ModifiedByWindowsUser { get; set; }

        [StringLength(2048)]
        public string Notes { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }
    }
}
