namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientConsult_Staging
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConsultID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }

        [StringLength(2)]
        public string ConsultType { get; set; }

        public DateTime? DateSeen { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VisitType { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool CoMorbidityVisit { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Seenby { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Height { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal Weight { get; set; }

        [StringLength(3)]
        public string WaistCircumference { get; set; }

        [StringLength(3)]
        public string HipCircumference { get; set; }

        [StringLength(3)]
        public string SagittalDiameter { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool ReportSent { get; set; }

        [StringLength(10)]
        public string ReservoirVolume { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool UpdateD { get; set; }

        public short? Months { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal BMIWeight { get; set; }

        public DateTime? DateNextVisit { get; set; }

        public decimal? BloodPressure { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal Neck { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal Hip { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal Waist { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool Image { get; set; }

        [StringLength(150)]
        public string ImageLocation { get; set; }

        public DateTime? ImageDate { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool Image1 { get; set; }

        [StringLength(150)]
        public string ImageLocation1 { get; set; }

        [StringLength(50)]
        public string ImageName1 { get; set; }

        public DateTime? ImageDate1 { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool Image2 { get; set; }

        [StringLength(150)]
        public string ImageLocation2 { get; set; }

        [StringLength(50)]
        public string ImageName2 { get; set; }

        public DateTime? ImageDate2 { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool Video { get; set; }

        [StringLength(150)]
        public string VideoLocation { get; set; }

        [StringLength(100)]
        public string VideoName { get; set; }

        [StringLength(250)]
        public string VideoResult { get; set; }

        public DateTime? VideoDate { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal WeightLastVisit { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal WeeksLastVisit { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal BMR { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal Impedance { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal FatPerCent { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal FreeFatMass { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal TotalBodyWater { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal FirstVisitWeight { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SystolicBP { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiastolicBP { get; set; }

        [StringLength(255)]
        public string BPRxDetails { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Triglycerides { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TotalCholesterol { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HDLCholesterol { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LDLCholesterol { get; set; }

        [StringLength(255)]
        public string LipidRxDetails { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal HBA1C { get; set; }

        [Key]
        [Column(Order = 34)]
        public decimal FSerumInsulin { get; set; }

        [Key]
        [Column(Order = 35)]
        public decimal FBloodGlucose { get; set; }

        [StringLength(255)]
        public string DiabetesRxDetails { get; set; }

        [Key]
        [Column(Order = 36)]
        public decimal Hemoglobin { get; set; }

        [Key]
        [Column(Order = 37)]
        public decimal Platelets { get; set; }

        [Key]
        [Column(Order = 38)]
        public decimal WCC { get; set; }

        [Key]
        [Column(Order = 39)]
        public decimal Iron { get; set; }

        [Key]
        [Column(Order = 40)]
        public decimal Ferritin { get; set; }

        [Key]
        [Column(Order = 41)]
        public decimal Transferrin { get; set; }

        [Key]
        [Column(Order = 42)]
        public decimal IBC { get; set; }

        [Key]
        [Column(Order = 43)]
        public decimal Folate { get; set; }

        [Key]
        [Column(Order = 44)]
        public decimal B12 { get; set; }

        [Key]
        [Column(Order = 45)]
        public decimal Sodium { get; set; }

        [Key]
        [Column(Order = 46)]
        public decimal Potassium { get; set; }

        [Key]
        [Column(Order = 47)]
        public decimal Chloride { get; set; }

        [Key]
        [Column(Order = 48)]
        public decimal Bicarbonate { get; set; }

        [Key]
        [Column(Order = 49)]
        public decimal Urea { get; set; }

        [Key]
        [Column(Order = 50)]
        public decimal Creatinine { get; set; }

        [Key]
        [Column(Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Homocysteine { get; set; }

        [Key]
        [Column(Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TSH { get; set; }

        [Key]
        [Column(Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int T4 { get; set; }

        [Key]
        [Column(Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int T3 { get; set; }

        [Key]
        [Column(Order = 55)]
        public decimal Albumin { get; set; }

        [Key]
        [Column(Order = 56)]
        public decimal Calcium { get; set; }

        [Key]
        [Column(Order = 57)]
        public decimal Phosphate { get; set; }

        [Key]
        [Column(Order = 58)]
        public decimal VitD { get; set; }

        [Key]
        [Column(Order = 59)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bilirubin { get; set; }

        [Key]
        [Column(Order = 60)]
        public decimal AlkPhos { get; set; }

        [Key]
        [Column(Order = 61)]
        public decimal ALT { get; set; }

        [Key]
        [Column(Order = 62)]
        public decimal AST { get; set; }

        [Key]
        [Column(Order = 63)]
        public decimal GGT { get; set; }

        [Key]
        [Column(Order = 64)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [StringLength(1024)]
        public string Notes { get; set; }
    }
}
