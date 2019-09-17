namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblOpEvent
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public int AdmitId { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        public DateTime? AdmitDate { get; set; }

        public decimal? OpWeight { get; set; }

        [StringLength(6)]
        public string HospitalCode { get; set; }

        public int SurgeonId { get; set; }

        public DateTime? OperationDate { get; set; }

        public int Duration { get; set; }

        public int DaysInHospital { get; set; }

        [StringLength(10)]
        public string SurgeryType { get; set; }

        [StringLength(50)]
        public string Approach { get; set; }

        [StringLength(10)]
        public string Category { get; set; }

        [StringLength(3)]
        public string Group { get; set; }

        public decimal StartNeck { get; set; }

        public decimal StartWaist { get; set; }

        public decimal StartHip { get; set; }

        [StringLength(30)]
        public string BandSize { get; set; }

        [StringLength(30)]
        public string ReservoirSite { get; set; }

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

        public decimal BloodLoss { get; set; }

        [StringLength(3)]
        public string RouxLimbLength { get; set; }

        [StringLength(10)]
        public string RouxColic { get; set; }

        [StringLength(10)]
        public string RouxGastric { get; set; }

        [StringLength(10)]
        public string RouxEnterostomy { get; set; }

        public bool Banded { get; set; }

        [StringLength(3)]
        public string VBGStomaSize { get; set; }

        [StringLength(10)]
        public string VBGStomaWrap { get; set; }

        public decimal BPDStomachSize { get; set; }

        [StringLength(3)]
        public string BPDIlealLength { get; set; }

        [StringLength(3)]
        public string BPDChannelLength { get; set; }

        public bool BPDDuodenalSwitch { get; set; }

        [StringLength(10)]
        public string TubeSize { get; set; }

        public bool PreviousSurgery { get; set; }

        [StringLength(10)]
        public string PrevAbdoSurgery1 { get; set; }

        [StringLength(10)]
        public string PrevAbdoSurgery2 { get; set; }

        [StringLength(10)]
        public string PrevAbdoSurgery3 { get; set; }

        [StringLength(255)]
        public string PrevAbdoSurgeryNotes { get; set; }

        public bool PrevPelvicSurgery { get; set; }

        [StringLength(10)]
        public string PrevPelvicSurgery1 { get; set; }

        [StringLength(10)]
        public string PrevPelvicSurgery2 { get; set; }

        [StringLength(10)]
        public string PrevPelvicSurgery3 { get; set; }

        [StringLength(255)]
        public string PrevPelvicSurgeryNotes { get; set; }

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

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }

        [StringLength(10)]
        public string LapbandType { get; set; }

        [StringLength(5)]
        public string InRoomTime { get; set; }

        [StringLength(5)]
        public string OutRoomTime { get; set; }

        [StringLength(5)]
        public string SurgeryStartTime { get; set; }

        [StringLength(5)]
        public string SurgeryEndTime { get; set; }

        [StringLength(500)]
        public string FirstAssistant { get; set; }

        [StringLength(5)]
        public string Bougie { get; set; }

        [StringLength(1024)]
        public string PreopHematocrit { get; set; }

        public DateTime? PreopHematocritDate { get; set; }

        [StringLength(1024)]
        public string PreopAlbumin { get; set; }

        public DateTime? PreopAlbuminDate { get; set; }

        public string OtherProcedure { get; set; }

        public int? NumberBloodTranfusion { get; set; }

        public int? NumberIntraopTranfusion { get; set; }

        public bool? UnplannedAdmission { get; set; }

        public bool? TransferAcuteCare { get; set; }
    }
}
