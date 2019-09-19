namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblOpEvents_Staging
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdmitId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientId { get; set; }

        public DateTime? AdmitDate { get; set; }

        public decimal? OpWeight { get; set; }

        [StringLength(6)]
        public string HospitalCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SurgeonId { get; set; }

        public DateTime? OperationDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Duration { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DaysInHospital { get; set; }

        [StringLength(10)]
        public string SurgeryType { get; set; }

        [StringLength(50)]
        public string Approach { get; set; }

        [StringLength(10)]
        public string Category { get; set; }

        [StringLength(3)]
        public string Group { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal StartNeck { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal StartWaist { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal StartHip { get; set; }

        [StringLength(30)]
        public string BandSize { get; set; }

        [StringLength(30)]
        public string ReservoirSite { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal BalloonVolume { get; set; }

        [StringLength(20)]
        public string Pathway { get; set; }

        [StringLength(16)]
        public string Indication { get; set; }

        [StringLength(16)]
        public string Procedure { get; set; }

        [StringLength(16)]
        public string Findings { get; set; }

        [StringLength(16)]
        public string Closure { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal BloodLoss { get; set; }

        [StringLength(3)]
        public string RouxLimbLength { get; set; }

        [StringLength(10)]
        public string RouxColic { get; set; }

        [StringLength(10)]
        public string RouxGastric { get; set; }

        [StringLength(10)]
        public string RouxEnterostomy { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool Banded { get; set; }

        [StringLength(3)]
        public string VBGStomaSize { get; set; }

        [StringLength(10)]
        public string VBGStomaWrap { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal BPDStomachSize { get; set; }

        [StringLength(3)]
        public string BPDIlealLength { get; set; }

        [StringLength(3)]
        public string BPDChannelLength { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool BPDDuodenalSwitch { get; set; }

        [StringLength(10)]
        public string TubeSize { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool PreviousSurgery { get; set; }

        [StringLength(10)]
        public string PrevAbdoSurgery1 { get; set; }

        [StringLength(10)]
        public string PrevAbdoSurgery2 { get; set; }

        [StringLength(10)]
        public string PrevAbdoSurgery3 { get; set; }

        [StringLength(255)]
        public string PrevAbdoSurgeryNotes { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool PrevPelvicSurgery { get; set; }

        [StringLength(10)]
        public string PrevPelvicSurgery1 { get; set; }

        [StringLength(10)]
        public string PrevPelvicSurgery2 { get; set; }

        [StringLength(10)]
        public string PrevPelvicSurgery3 { get; set; }

        [StringLength(255)]
        public string PrevPelvicSurgeryNotes { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool ComcomitantSurgery { get; set; }

        [StringLength(10)]
        public string ComcomitantSurgery1 { get; set; }

        [StringLength(10)]
        public string ComcomitantSurgery2 { get; set; }

        [StringLength(10)]
        public string ComcomitantSurgery3 { get; set; }

        [StringLength(255)]
        public string ComcomitantSurgeryNotes { get; set; }

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

        [StringLength(1024)]
        public string GeneralNotes { get; set; }
    }
}
