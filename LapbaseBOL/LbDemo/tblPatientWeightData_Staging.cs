namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientWeightData_Staging
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }

        public DateTime? LapBandDate { get; set; }

        [StringLength(2048)]
        public string Notes { get; set; }

        public decimal? Height { get; set; }

        public decimal? StartWeight { get; set; }

        public DateTime? StartWeightDate { get; set; }

        public decimal? IdealWeight { get; set; }

        public decimal? CurrentWeight { get; set; }

        public decimal? OpWeight { get; set; }

        public decimal? TargetWeight { get; set; }

        public bool? Excluded { get; set; }

        public decimal? LastReservoirVol { get; set; }

        public bool? losttofollowup { get; set; }

        public decimal? StartBMIWeight { get; set; }

        public decimal? BMIHeight { get; set; }

        [StringLength(150)]
        public string LastImageLocation { get; set; }

        public DateTime? LastImageDate { get; set; }

        [StringLength(10)]
        public string SurgeryType { get; set; }

        [StringLength(50)]
        public string Approach { get; set; }

        [StringLength(10)]
        public string Category { get; set; }

        [StringLength(6)]
        public string Group { get; set; }

        public DateTime? BaseAssessmentDate { get; set; }

        [StringLength(255)]
        public string BaseOtherDetails { get; set; }

        public bool? BaseHypertensionProblems { get; set; }

        [StringLength(255)]
        public string BaseBloodPressureRxDetails { get; set; }

        public int? BaseSystolicBP { get; set; }

        public int? BaseDiastolicBP { get; set; }

        public bool? HypertensionResolved { get; set; }

        public DateTime? HypertensionResolvedDate { get; set; }

        public int? HypertensionResolvedSystolic { get; set; }

        public int? HypertensionResolvedDiastolic { get; set; }

        public bool? BaseLipidProblems { get; set; }

        [StringLength(255)]
        public string BaseLipidRxDetails { get; set; }

        public decimal? BaseTriglycerides { get; set; }

        public decimal? BaseTotalCholesterol { get; set; }

        public decimal? BaseHDLCholesterol { get; set; }

        public bool? LipidsResolved { get; set; }

        public DateTime? LipidsResolvedDate { get; set; }

        public bool? BaseDiabetesProblems { get; set; }

        [StringLength(255)]
        public string BaseDiabetesRxDetails { get; set; }

        public bool? DiabetesResolved { get; set; }

        public DateTime? DiabetesResolvedDate { get; set; }

        public int? DiabetesResolvedFBglucose { get; set; }

        public bool? BaseAsthmaProblems { get; set; }

        [StringLength(2)]
        public string BaseAsthmaLevel { get; set; }

        [StringLength(255)]
        public string BaseAsthmaDetails { get; set; }

        public bool? AsthmaResolved { get; set; }

        public DateTime? AsthmaResolvedDate { get; set; }

        [StringLength(2)]
        public string AsthmaResolvedLevel { get; set; }

        [StringLength(2)]
        public string AsthmaCurrentLevel { get; set; }

        public bool? BaseRefluxProblems { get; set; }

        [StringLength(255)]
        public string BaseRefluxDetails { get; set; }

        [StringLength(2)]
        public string BaseRefluxLevel { get; set; }

        public bool? RefluxResolved { get; set; }

        public DateTime? RefluxResolvedDate { get; set; }

        [StringLength(2)]
        public string RefluxResolvedLevel { get; set; }

        [StringLength(2)]
        public string RefluxCurrentLevel { get; set; }

        public bool? BaseOtherRx { get; set; }

        [StringLength(255)]
        public string BaseOtherRxDetails { get; set; }

        public bool? BaseSleepProblems { get; set; }

        [StringLength(255)]
        public string BaseSleepDetails { get; set; }

        [StringLength(2)]
        public string BaseSleepLevel { get; set; }

        public bool? SleepResolved { get; set; }

        public DateTime? SleepResolvedDate { get; set; }

        [StringLength(2)]
        public string SleepResolvedLevel { get; set; }

        [StringLength(2)]
        public string SleepCurrentLevel { get; set; }

        public bool? BaseFertilityProblems { get; set; }

        [StringLength(2)]
        public string BaseFertilityLevel { get; set; }

        [StringLength(255)]
        public string BaseFertilityDetails { get; set; }

        public bool? FertilityResolved { get; set; }

        public DateTime? FertilityResolvedDate { get; set; }

        [StringLength(2)]
        public string FertilityResolvedLevel { get; set; }

        [StringLength(2)]
        public string FertilityCurrentLevel { get; set; }

        public bool? BaseArthritisProblems { get; set; }

        [StringLength(255)]
        public string BaseArthritisDetails { get; set; }

        [StringLength(2)]
        public string BaseArthritisLevel { get; set; }

        public bool? ArthritisResolved { get; set; }

        public DateTime? ArthritisResolvedDate { get; set; }

        [StringLength(2)]
        public string ArthritisResolvedLevel { get; set; }

        [StringLength(2)]
        public string ArthritisCurrentLevel { get; set; }

        public bool? BaseIncontinenceProblems { get; set; }

        [StringLength(255)]
        public string BaseIncontinenceDetails { get; set; }

        [StringLength(2)]
        public string BaseIncontinenceLevel { get; set; }

        public bool? IncontinenceResolved { get; set; }

        public DateTime? IncontinenceResolvedDate { get; set; }

        [StringLength(2)]
        public string IncontinenceResolvedLevel { get; set; }

        [StringLength(2)]
        public string IncontinenceCurrentLevel { get; set; }

        public bool? BaseBackProblems { get; set; }

        [StringLength(255)]
        public string BaseBackDetails { get; set; }

        [StringLength(2)]
        public string BaseBackPainLevel { get; set; }

        public bool? BackResolved { get; set; }

        public DateTime? BackResolvedDate { get; set; }

        [StringLength(2)]
        public string BackResolvedLevel { get; set; }

        [StringLength(2)]
        public string BackCurrentLevel { get; set; }

        public bool? BaseCVDProblems { get; set; }

        [StringLength(255)]
        public string BaseCVDDetails { get; set; }

        [StringLength(2)]
        public string BaseCVDLevel { get; set; }

        public bool? CVDLevelResolved { get; set; }

        public DateTime? CVDLevelResolvedDate { get; set; }

        [StringLength(2)]
        public string CVDLevelCurrentLevel { get; set; }

        [StringLength(2)]
        public string CVDLevelResolvedLevel { get; set; }

        public decimal? StartNeck { get; set; }

        public decimal? StartWaist { get; set; }

        public decimal? StartHip { get; set; }

        public decimal? BaseBodyFat { get; set; }

        public decimal? BaseFatMass { get; set; }

        public decimal? BaseBMR { get; set; }

        public decimal? BaseImpedance { get; set; }

        public decimal? BaseFatPerCent { get; set; }

        public decimal? BaseFreeFatMass { get; set; }

        public decimal? BaseTotalBodyWater { get; set; }

        public int? BaseHomocysteine { get; set; }

        public int? BaseTSH { get; set; }

        public int? BaseT4 { get; set; }

        public int? BaseT3 { get; set; }

        public decimal? BaseHBA1C { get; set; }

        public decimal? BaseFSerumInsulin { get; set; }

        public decimal? BaseFBloodGlucose { get; set; }

        public decimal? BaseIron { get; set; }

        public decimal? BaseFerritin { get; set; }

        public decimal? BaseTransferrin { get; set; }

        public decimal? BaseIBC { get; set; }

        public decimal? BaseFolate { get; set; }

        public decimal? BaseB12 { get; set; }

        public decimal? BaseHemoglobin { get; set; }

        public decimal? BasePlatelets { get; set; }

        public decimal? BaseWCC { get; set; }

        public decimal? BaseCalcium { get; set; }

        public decimal? BasePhosphate { get; set; }

        public decimal? BaseVitD { get; set; }

        public decimal? BaseBilirubin { get; set; }

        public decimal? BaseTProtein { get; set; }

        public decimal? BaseAlkPhos { get; set; }

        public decimal? BaseALT { get; set; }

        public decimal? BaseAST { get; set; }

        public decimal? BaseGGT { get; set; }

        public decimal? BaseCPK { get; set; }

        public decimal? BaseAlbumin { get; set; }

        public decimal? BaseSodium { get; set; }

        public decimal? BasePotassium { get; set; }

        public decimal? BaseChloride { get; set; }

        public decimal? BaseBicarbonate { get; set; }

        public decimal? BaseUrea { get; set; }

        public decimal? BaseCreatinine { get; set; }

        [StringLength(25)]
        public string BaseUserField1 { get; set; }

        [StringLength(25)]
        public string BaseUserField2 { get; set; }

        [StringLength(25)]
        public string BaseUserField3 { get; set; }

        [StringLength(25)]
        public string BaseUserField4 { get; set; }

        [StringLength(25)]
        public string BaseUserField5 { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? NextComorbidVisit { get; set; }

        public decimal? ComorbidityMonths { get; set; }

        public bool? ComorbidtyOnFile { get; set; }

        public decimal? OpBMIWeight { get; set; }

        public decimal? BaseLDLCholesterol { get; set; }

        [StringLength(512)]
        public string BaseUserMemoField1 { get; set; }

        [StringLength(512)]
        public string BaseUserMemoField2 { get; set; }

        [StringLength(255)]
        public string BaseReason7 { get; set; }

        [StringLength(255)]
        public string BaseReason8 { get; set; }

        public decimal? BMI { get; set; }

        public bool? BaseHDLCholesterolProblems { get; set; }

        public bool? BaseTriglycerideProblems { get; set; }

        public bool? BaseBaselineHStatus { get; set; }

        public bool? BaseCholesterolProblems { get; set; }

        public DateTime? BaseOtherProblems { get; set; }

        public bool? BaseDiabetesRx { get; set; }

        public bool? BaseLipidRx { get; set; }

        public bool? BaseBloodPressureRx { get; set; }

        public decimal? BaseBloodGlucoseLevel { get; set; }

        public decimal? FirstVisitWeight { get; set; }

        public decimal? BaseBMC { get; set; }

        public decimal? BaseLeanBodyMass { get; set; }

        public decimal? BaseBodyFatPC { get; set; }

        public decimal? BaseBMIPercentile { get; set; }

        public decimal? BaseZScore { get; set; }

        public bool? COMData { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(4)]
        public string MaxWeightYr { get; set; }

        public decimal? MaxWeight { get; set; }

        public bool? Updated { get; set; }

        public bool? PatientReport { get; set; }

        public bool? ProcedureReport { get; set; }

        public short? TempFlag { get; set; }

        [StringLength(10)]
        public string LapbandType { get; set; }

        [StringLength(30)]
        public string LapbandSize { get; set; }

        public int? StartPR { get; set; }

        public int? StartRR { get; set; }

        public int? StartBP1 { get; set; }

        public int? StartBP2 { get; set; }

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

        [StringLength(1024)]
        public string PreopHematocrit { get; set; }

        public DateTime? PreopHematocritDate { get; set; }

        [StringLength(1024)]
        public string PreopAlbumin { get; set; }

        [MaxLength(50)]
        public byte[] PreopAlbuminDate { get; set; }

        public string OtherProcedure { get; set; }

        [StringLength(50)]
        public string ASACode { get; set; }

        public string Concurrent { get; set; }

        public DateTime? DischargeDate { get; set; }

        public decimal? BloodTransfusion { get; set; }

        public int? NumberBloodTranfusion { get; set; }

        public int? NumberIntraopTranfusion { get; set; }

        public bool? UnplannedAdmission { get; set; }

        public bool? TransferAcuteCare { get; set; }

        public DateTime? ZeroDate { get; set; }

        public int? VisitWeeksFlag { get; set; }
    }
}
