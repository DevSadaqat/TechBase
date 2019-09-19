namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblOpEvents_Bold
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdmitId { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        public int LastConsultIDBeforeOperation { get; set; }

        public int? AnesthesiaDuration { get; set; }

        [StringLength(50)]
        public string DVTCode { get; set; }

        [StringLength(10)]
        public string ASACode { get; set; }

        [StringLength(10)]
        public string SurgicalAssistance { get; set; }

        public string Concurrent { get; set; }

        public string IntraEvents { get; set; }

        public string PreDischargeEvents { get; set; }

        public int? TimeAfterSurgery { get; set; }

        public DateTime? DischargeDate { get; set; }

        [StringLength(10)]
        public string DischargeTo { get; set; }

        public decimal? BloodTransfusion { get; set; }

        [StringLength(50)]
        public string SerialNo { get; set; }

        [StringLength(10)]
        public string BandType { get; set; }

        public DateTime? AdmitDate { get; set; }

        public DateTime? OperationDate { get; set; }

        [StringLength(6)]
        public string HospitalCode { get; set; }

        public int SurgeonId { get; set; }

        public int Duration { get; set; }

        [StringLength(50)]
        public string SurgeryType { get; set; }

        [StringLength(50)]
        public string Approach { get; set; }

        public decimal BloodLoss { get; set; }

        public DateTime? LastSeen { get; set; }

        public decimal? LastWeight { get; set; }

        public bool? Bold_Flag { get; set; }

        public bool Bold_Sent { get; set; }

        public bool SurgicalFellowParticipated { get; set; }

        public bool SurgicalResidentParticipated { get; set; }

        public bool DVTAntigloculan { get; set; }

        public bool DVTTED { get; set; }

        public bool DVTFootPump { get; set; }

        public bool DVTCompress { get; set; }

        [StringLength(50)]
        public string HospitalID { get; set; }

        [StringLength(50)]
        public string TimeAfterSurgeryMeasurement { get; set; }

        public int PreDischargeSurgeon { get; set; }

        [StringLength(255)]
        public string PreDischargeSurgery { get; set; }

        [StringLength(50)]
        public string RegistryProcedure { get; set; }
    }
}
