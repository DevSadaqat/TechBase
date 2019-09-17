namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientConsultLog")]
    public partial class tblPatientConsultLog
    {
        [Key]
        public int ConsultLogID { get; set; }

        public int ConsultID { get; set; }

        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [Column("Patient Id")]
        public int Patient_Id { get; set; }

        [StringLength(2)]
        public string ConsultType { get; set; }

        public DateTime? DateSeen { get; set; }

        public short VisitType { get; set; }

        public bool CoMorbidityVisit { get; set; }

        public int Seenby { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        [StringLength(3)]
        public string WaistCircumference { get; set; }

        [StringLength(3)]
        public string HipCircumference { get; set; }

        [StringLength(3)]
        public string SagittalDiameter { get; set; }

        public bool ReportSent { get; set; }

        [StringLength(10)]
        public string ReservoirVolume { get; set; }

        public bool UpdateD { get; set; }

        public short? Months { get; set; }

        public decimal BMIWeight { get; set; }

        public DateTime? DateNextVisit { get; set; }

        public decimal? BloodPressure { get; set; }

        public decimal? Neck { get; set; }

        public decimal? Hip { get; set; }

        public decimal? Waist { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        public bool Image { get; set; }

        [StringLength(150)]
        public string ImageLocation { get; set; }

        public DateTime? ImageDate { get; set; }

        public bool Image1 { get; set; }

        [StringLength(150)]
        public string ImageLocation1 { get; set; }

        [StringLength(50)]
        public string ImageName1 { get; set; }

        public DateTime? ImageDate1 { get; set; }

        public bool Image2 { get; set; }

        [StringLength(150)]
        public string ImageLocation2 { get; set; }

        [StringLength(50)]
        public string ImageName2 { get; set; }

        public DateTime? ImageDate2 { get; set; }

        public bool Video { get; set; }

        [StringLength(150)]
        public string VideoLocation { get; set; }

        [StringLength(100)]
        public string VideoName { get; set; }

        [StringLength(250)]
        public string VideoResult { get; set; }

        public DateTime? VideoDate { get; set; }

        public decimal WeightLastVisit { get; set; }

        public decimal WeeksLastVisit { get; set; }

        public decimal BMR { get; set; }

        public decimal Impedance { get; set; }

        public decimal FatPerCent { get; set; }

        public decimal FreeFatMass { get; set; }

        public decimal TotalBodyWater { get; set; }

        public decimal FirstVisitWeight { get; set; }

        public int SystolicBP { get; set; }

        public int DiastolicBP { get; set; }

        [StringLength(255)]
        public string BPRxDetails { get; set; }

        public int Triglycerides { get; set; }

        public int TotalCholesterol { get; set; }

        public int HDLCholesterol { get; set; }

        public int LDLCholesterol { get; set; }

        [StringLength(255)]
        public string LipidRxDetails { get; set; }

        public decimal HBA1C { get; set; }

        public decimal FSerumInsulin { get; set; }

        public decimal FBloodGlucose { get; set; }

        [StringLength(255)]
        public string DiabetesRxDetails { get; set; }

        public decimal Hemoglobin { get; set; }

        public decimal Platelets { get; set; }

        public decimal WCC { get; set; }

        public decimal Iron { get; set; }

        public decimal Ferritin { get; set; }

        public decimal Transferrin { get; set; }

        public decimal IBC { get; set; }

        public decimal Folate { get; set; }

        public decimal B12 { get; set; }

        public decimal Sodium { get; set; }

        public decimal Potassium { get; set; }

        public decimal Chloride { get; set; }

        public decimal Bicarbonate { get; set; }

        public decimal Urea { get; set; }

        public decimal Creatinine { get; set; }

        public int Homocysteine { get; set; }

        public int TSH { get; set; }

        public int T4 { get; set; }

        public int T3 { get; set; }

        public decimal Albumin { get; set; }

        public decimal Calcium { get; set; }

        public decimal Phosphate { get; set; }

        public decimal VitD { get; set; }

        public int Bilirubin { get; set; }

        public decimal AlkPhos { get; set; }

        public decimal ALT { get; set; }

        public decimal AST { get; set; }

        public decimal GGT { get; set; }

        public int TProtein { get; set; }

        [StringLength(50)]
        public string UserField1 { get; set; }

        [StringLength(50)]
        public string UserField2 { get; set; }

        [StringLength(50)]
        public string UserField3 { get; set; }

        [StringLength(50)]
        public string UserField4 { get; set; }

        [StringLength(50)]
        public string UserField5 { get; set; }

        [StringLength(10)]
        public string AsthmaLevel { get; set; }

        [StringLength(10)]
        public string RefluxLevel { get; set; }

        [StringLength(10)]
        public string SleepLevel { get; set; }

        [StringLength(10)]
        public string FertilityLevel { get; set; }

        [StringLength(10)]
        public string IncontinenceLevel { get; set; }

        [StringLength(10)]
        public string BackLevel { get; set; }

        [StringLength(10)]
        public string ArthritisLevel { get; set; }

        [StringLength(10)]
        public string CVDLevel { get; set; }

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

        [StringLength(255)]
        public string OtherRxDetails { get; set; }

        public bool? HypertensionProblems { get; set; }

        public bool? LipidRx { get; set; }

        public bool? DiabetesRx { get; set; }

        public bool? BloodPressureRx { get; set; }

        public bool? OtherRx { get; set; }

        public bool? LipidProblems { get; set; }

        public bool? AsthmaProblems { get; set; }

        public bool? SleepProblems { get; set; }

        public bool? IncontinenceProblems { get; set; }

        public bool? BackProblems { get; set; }

        public bool? ArthritisProblems { get; set; }

        public bool? FertilityProblems { get; set; }

        public bool? RefluxProblems { get; set; }

        public bool? DiabetesProblems { get; set; }

        [StringLength(512)]
        public string UserMemoField1 { get; set; }

        [StringLength(512)]
        public string UserMemoField2 { get; set; }

        [StringLength(512)]
        public string Notes2 { get; set; }

        [StringLength(2048)]
        public string Notes { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }

        public int? PulseRate { get; set; }

        public int? RespiratoryRate { get; set; }

        public int? BloodPressureUpper { get; set; }

        public int? BloodPressureLower { get; set; }

        [StringLength(512)]
        public string GeneralReview { get; set; }

        [StringLength(512)]
        public string CardiovascularReview { get; set; }

        [StringLength(512)]
        public string RespiratoryReview { get; set; }

        [StringLength(512)]
        public string GastroReview { get; set; }

        [StringLength(512)]
        public string GenitoReview { get; set; }

        [StringLength(512)]
        public string ExtremitiesReview { get; set; }

        [StringLength(512)]
        public string NeurologicalReview { get; set; }

        public int? SatietyStaging { get; set; }

        [StringLength(50)]
        public string ChiefComplaint { get; set; }

        [StringLength(512)]
        public string MusculoskeletalReview { get; set; }

        [StringLength(512)]
        public string SkinReview { get; set; }

        [StringLength(512)]
        public string PsychiatricReview { get; set; }

        [StringLength(512)]
        public string EndocrineReview { get; set; }

        [StringLength(512)]
        public string HematologicReview { get; set; }

        [StringLength(512)]
        public string ENTReview { get; set; }

        [StringLength(512)]
        public string EyesReview { get; set; }

        [StringLength(512)]
        public string PFSHReview { get; set; }

        [StringLength(512)]
        public string MedicationsReview { get; set; }

        [StringLength(2048)]
        public string LapbandAdjustment { get; set; }

        public int? MedicalProvider { get; set; }

        public bool? AdjConsent { get; set; }

        public bool? AdjAntiseptic { get; set; }

        public bool? AdjAnesthesia { get; set; }

        public decimal? AdjAnesthesiaVol { get; set; }

        public bool? AdjNeedle { get; set; }

        public bool? AdjVolume { get; set; }

        public decimal? AdjInitialVol { get; set; }

        public decimal? AdjAddVol { get; set; }

        public decimal? AdjRemoveVol { get; set; }

        public bool? AdjTolerate { get; set; }

        public bool? AdjBarium { get; set; }

        public bool? AdjOmni { get; set; }

        public bool? AdjProtocol { get; set; }

        public bool? ProgressReview { get; set; }

        public bool? LetterSent { get; set; }

        [StringLength(50)]
        public string SupportGroup { get; set; }

        public bool? RegistryReview { get; set; }

        [StringLength(50)]
        public string RegistrySleepApnea { get; set; }

        [StringLength(50)]
        public string RegistryGerd { get; set; }

        [StringLength(50)]
        public string RegistryHyperlipidemia { get; set; }

        [StringLength(50)]
        public string RegistryDiabetes { get; set; }

        [StringLength(50)]
        public string RegistryHypertension { get; set; }

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }

        public bool? RegistryDiabetesDetail { get; set; }

        public bool? RegistryTreatmentDiet { get; set; }

        public bool? RegistryTreatmentOral { get; set; }

        public bool? RegistryTreatmentInsulin { get; set; }

        public bool? RegistryTreatmentOther { get; set; }

        public bool? RegistryTreatmentCombination { get; set; }

        public bool? RegistryReoperation { get; set; }

        [StringLength(512)]
        public string RegistryReoperationNote { get; set; }

        public bool? RegistrySEDetail { get; set; }

        [StringLength(50)]
        public string RegistrySEList { get; set; }

        [StringLength(512)]
        public string RegistrySENote { get; set; }
    }
}
