namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatient
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 1)]
        public int Patient_Id { get; set; }

        [Column("Name Id")]
        [StringLength(7)]
        public string Name_Id { get; set; }

        [Column("Reference Id")]
        [StringLength(20)]
        public string Reference_Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Surname { get; set; }

        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }

        public short? Title { get; set; }

        [StringLength(40)]
        public string Street { get; set; }

        [StringLength(40)]
        public string Suburb { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(10)]
        public string Postcode { get; set; }

        [Column("Home Phone")]
        [StringLength(30)]
        public string Home_Phone { get; set; }

        [Column("Work Phone")]
        [StringLength(30)]
        public string Work_Phone { get; set; }

        [StringLength(30)]
        public string MobilePhone { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(2)]
        public string Sex { get; set; }

        [StringLength(100)]
        public string Race { get; set; }

        [StringLength(50)]
        public string Insurance { get; set; }

        [Column("Doctor Id")]
        public int? Doctor_Id { get; set; }

        [Column("Date First Visit")]
        public DateTime? Date_First_Visit { get; set; }

        [Column("Date Last Visit")]
        public DateTime? Date_Last_Visit { get; set; }

        [StringLength(10)]
        public string RefDrId1 { get; set; }

        [StringLength(10)]
        public string RefDrId2 { get; set; }

        [StringLength(10)]
        public string RefDrId3 { get; set; }

        public bool? Select { get; set; }

        public short? Select2 { get; set; }

        public short? Select3 { get; set; }

        [Column("Date Next Visit")]
        public DateTime? Date_Next_Visit { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(50)]
        public string CreatedByUser { get; set; }

        [StringLength(50)]
        public string CreatedByComputer { get; set; }

        public DateTime? LastModified { get; set; }

        [StringLength(50)]
        public string ModifiedByUser { get; set; }

        [StringLength(50)]
        public string ModifiedByComputer { get; set; }

        [StringLength(6)]
        public string RemoteDrId { get; set; }

        [StringLength(50)]
        public string CreatedByWindowsUser { get; set; }

        [StringLength(50)]
        public string ModifiedByWindowsUser { get; set; }

        public int? WebExport { get; set; }

        [Column("Marital status")]
        [StringLength(50)]
        public string Marital_status { get; set; }

        public DateTime? ReferralDate { get; set; }

        [StringLength(20)]
        public string ReferralDuration { get; set; }

        [StringLength(2048)]
        public string SocialHistory { get; set; }

        [Column("Patient MD Id")]
        public int? Patient_MD_Id { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }

        public DateTime? ZeroDate { get; set; }

        public DateTime? RefDrDate1 { get; set; }

        public DateTime? RefDrDate2 { get; set; }

        public DateTime? RefDrDate3 { get; set; }

        [StringLength(50)]
        public string RefDrDuration1 { get; set; }

        [StringLength(50)]
        public string RefDrDuration2 { get; set; }

        [StringLength(50)]
        public string RefDrDuration3 { get; set; }

        [StringLength(50)]
        public string RefDrStatus1 { get; set; }

        [StringLength(50)]
        public string RefDrStatus2 { get; set; }

        [StringLength(50)]
        public string RefDrStatus3 { get; set; }

        public DateTime? ConsultationDate { get; set; }

        public string MedicalSummary { get; set; }
    }
}
