namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientEMRLog")]
    public partial class tblPatientEMRLog
    {
        [Key]
        public int PatientEMRLogID { get; set; }

        public int OrganizationCode { get; set; }

        [Column("Patient Id")]
        public int Patient_Id { get; set; }

        [StringLength(100)]
        public string Details_Occupation { get; set; }

        [StringLength(50)]
        public string Details_FamilyStructure { get; set; }

        [StringLength(3)]
        public string Details_LiveAtHome { get; set; }

        [StringLength(50)]
        public string Details_SpouseName { get; set; }

        [StringLength(50)]
        public string Details_Children { get; set; }

        [StringLength(50)]
        public string Details_NextOfKinName { get; set; }

        [StringLength(50)]
        public string Details_NextOfKinRelation { get; set; }

        [StringLength(200)]
        public string Details_NextOfKinAddress { get; set; }

        [StringLength(30)]
        public string Details_NextOfKinHomePhone { get; set; }

        [StringLength(30)]
        public string Details_NextOfKinWorkPhone { get; set; }

        [StringLength(30)]
        public string Details_NextOfKinMobile { get; set; }

        [StringLength(50)]
        public string Details_AddContact1Name { get; set; }

        [StringLength(50)]
        public string Details_AddContact1Relation { get; set; }

        [StringLength(200)]
        public string Details_AddContact1Address { get; set; }

        [StringLength(30)]
        public string Details_AddContact1HomePhone { get; set; }

        [StringLength(30)]
        public string Details_AddContact1Mobile { get; set; }

        [StringLength(50)]
        public string Details_AddContact2Name { get; set; }

        [StringLength(50)]
        public string Details_AddContact2Relation { get; set; }

        [StringLength(200)]
        public string Details_AddContact2Address { get; set; }

        [StringLength(30)]
        public string Details_AddContact2HomePhone { get; set; }

        [StringLength(30)]
        public string Details_AddContact2Mobile { get; set; }

        [StringLength(512)]
        public string Background_Diabetes { get; set; }

        [StringLength(512)]
        public string Background_HeartDisease { get; set; }

        [StringLength(512)]
        public string Background_Hypertension { get; set; }

        [StringLength(512)]
        public string Background_Gout { get; set; }

        [StringLength(512)]
        public string Background_Obesity { get; set; }

        [StringLength(512)]
        public string Background_Snoring { get; set; }

        [StringLength(512)]
        public string Background_Asthma { get; set; }

        [StringLength(512)]
        public string Background_HighCholesterol { get; set; }

        [StringLength(2048)]
        public string Background_FamilyHistory { get; set; }

        [StringLength(2048)]
        public string Background_PastHealth { get; set; }

        public string Background_PreviousBariatric { get; set; }

        public string Background_PreviousNonBariatric { get; set; }

        [StringLength(150)]
        public string SpecialInvestigation_SuggestedSS { get; set; }

        [StringLength(5)]
        public string SpecialInvestigation_ActionSS { get; set; }

        [StringLength(150)]
        public string SpecialInvestigation_SuggestedGE { get; set; }

        [StringLength(5)]
        public string SpecialInvestigation_ActionGE { get; set; }

        [StringLength(150)]
        public string SpecialInvestigation_SuggestedSP { get; set; }

        [StringLength(5)]
        public string SpecialInvestigation_ActionSP { get; set; }

        [StringLength(150)]
        public string SpecialInvestigation_SuggestedNA { get; set; }

        [StringLength(5)]
        public string SpecialInvestigation_ActionNA { get; set; }

        [StringLength(150)]
        public string SpecialInvestigation_SuggestedPS { get; set; }

        [StringLength(5)]
        public string SpecialInvestigation_ActionPS { get; set; }

        [StringLength(150)]
        public string SpecialInvestigation_SuggestedOA { get; set; }

        [StringLength(5)]
        public string SpecialInvestigation_ActionOA { get; set; }

        [StringLength(512)]
        public string ReviewSystem_PFSH { get; set; }

        [StringLength(512)]
        public string ReviewSystem_General { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Gastro { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Cardio { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Resp { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Musculo { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Extr { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Genito { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Skin { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Neuro { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Psych { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Endo { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Hema { get; set; }

        [StringLength(512)]
        public string ReviewSystem_ENT { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Eyes { get; set; }

        [StringLength(512)]
        public string ReviewSystem_Meds { get; set; }

        [StringLength(2048)]
        public string Medication { get; set; }

        public bool? Allergy_HaveAllergy { get; set; }

        [StringLength(512)]
        public string Allergy_ListAllergy { get; set; }

        public bool? Allergy_HaveMedication { get; set; }

        [StringLength(512)]
        public string Allergy_ListMedication { get; set; }

        public bool? Allergy_Latex { get; set; }

        [StringLength(512)]
        public string Allergy_Anesthetic { get; set; }

        public bool? Allergy_ExcessBleed { get; set; }

        [StringLength(512)]
        public string Allergy_AnestheticRisk { get; set; }

        [StringLength(20)]
        public string Allergy_HaveDrink { get; set; }

        [StringLength(20)]
        public string Allergy_DrinkPerDay { get; set; }

        [StringLength(20)]
        public string Allergy_DrinkPerWeek { get; set; }

        public bool? Allergy_DrinkBeer { get; set; }

        public bool? Allergy_DrinkWine { get; set; }

        public bool? Allergy_DrinkSpirits { get; set; }

        [StringLength(20)]
        public string Allergy_Smoke { get; set; }

        [StringLength(20)]
        public string Allergy_SmokePerDay { get; set; }

        public bool? Allergy_HaveSmoke { get; set; }

        [StringLength(20)]
        public string Allergy_HaveSmokePerDay { get; set; }

        [StringLength(20)]
        public string Allergy_HaveSmokeYears { get; set; }

        [StringLength(20)]
        public string Allergy_HaveSmokeStop { get; set; }

        [StringLength(20)]
        public string WeightHistory_WeightBirth { get; set; }

        [StringLength(20)]
        public string WeightHistory_WeightStartSchool { get; set; }

        [StringLength(20)]
        public string WeightHistory_WeightStartHighSchool { get; set; }

        [StringLength(20)]
        public string WeightHistory_WeightEndHighSchool { get; set; }

        [StringLength(20)]
        public string WeightHistory_WeightWork { get; set; }

        [StringLength(20)]
        public string WeightHistory_WeightMarriage { get; set; }

        [StringLength(512)]
        public string WeightHistory_LoseYears { get; set; }

        [StringLength(512)]
        public string WeightHistory_TryMethod { get; set; }

        [StringLength(512)]
        public string WeightHistory_GroupList { get; set; }

        [StringLength(512)]
        public string WeightHistory_GroupOther { get; set; }

        [StringLength(512)]
        public string WeightHistory_PillList { get; set; }

        [StringLength(512)]
        public string WeightHistory_PillOther { get; set; }

        [StringLength(512)]
        public string WeightHistory_AdviceList { get; set; }

        [StringLength(512)]
        public string WeightHistory_AdviceOther { get; set; }

        [StringLength(512)]
        public string WeightHistory_DietList { get; set; }

        [StringLength(512)]
        public string WeightHistory_Other { get; set; }

        [StringLength(512)]
        public string WeightHistory_TreatmentList { get; set; }

        [StringLength(512)]
        public string WeightHistory_CosmeticList { get; set; }

        [StringLength(512)]
        public string Investigation_RBS { get; set; }

        [StringLength(10)]
        public string Investigation_ActionRBS { get; set; }

        [StringLength(150)]
        public string Investigation_ABS { get; set; }

        [StringLength(5)]
        public string Investigation_ActionABS { get; set; }

        [StringLength(150)]
        public string Investigation_RFT { get; set; }

        [StringLength(5)]
        public string Investigation_ActionRFT { get; set; }

        [StringLength(150)]
        public string Investigation_ABG { get; set; }

        [StringLength(5)]
        public string Investigation_ActionABG { get; set; }

        [StringLength(150)]
        public string Investigation_EET { get; set; }

        [StringLength(5)]
        public string Investigation_ActionEET { get; set; }

        [StringLength(150)]
        public string Investigation_BM { get; set; }

        [StringLength(5)]
        public string Investigation_ActionBM { get; set; }

        [StringLength(150)]
        public string Investigation_EMS { get; set; }

        [StringLength(5)]
        public string Investigation_ActionEMS { get; set; }

        [StringLength(150)]
        public string Investigation_P { get; set; }

        [StringLength(5)]
        public string Investigation_ActionP { get; set; }

        [StringLength(150)]
        public string Investigation_EKG { get; set; }

        [StringLength(5)]
        public string Investigation_ActionEKG { get; set; }

        [StringLength(150)]
        public string Investigation_CX { get; set; }

        [StringLength(5)]
        public string Investigation_ActionCX { get; set; }

        [StringLength(2048)]
        public string Exam_Notes { get; set; }

        [StringLength(512)]
        public string Exam_GAO { get; set; }

        [StringLength(512)]
        public string Exam_HNG { get; set; }

        [StringLength(512)]
        public string Exam_HNH { get; set; }

        [StringLength(512)]
        public string Exam_HNM { get; set; }

        [StringLength(512)]
        public string Exam_HNN { get; set; }

        [StringLength(512)]
        public string Exam_CH { get; set; }

        [StringLength(512)]
        public string Exam_CP { get; set; }

        [StringLength(512)]
        public string Exam_AA { get; set; }

        [StringLength(512)]
        public string Exam_LSR { get; set; }

        [StringLength(512)]
        public string Exam_LSB { get; set; }

        [StringLength(512)]
        public string Exam_LSA { get; set; }

        [StringLength(512)]
        public string Exam_MSO { get; set; }

        [StringLength(512)]
        public string Exam_MF { get; set; }

        [StringLength(512)]
        public string Referrals_PA { get; set; }

        [StringLength(512)]
        public string Referrals_C { get; set; }

        [StringLength(512)]
        public string Referrals_RP { get; set; }

        [StringLength(512)]
        public string Referrals_E { get; set; }

        [StringLength(512)]
        public string Referrals_AP { get; set; }

        [StringLength(512)]
        public string Referrals_GM { get; set; }

        [StringLength(512)]
        public string Referrals_O { get; set; }

        [StringLength(10)]
        public string Complaint { get; set; }

        [StringLength(2048)]
        public string ComplaintNotes { get; set; }

        [StringLength(2048)]
        public string Management { get; set; }

        public bool? Allergy_DoDrugs { get; set; }

        [StringLength(512)]
        public string Allergy_DoDrugs_Notes { get; set; }

        [StringLength(2048)]
        public string Lab_Notes { get; set; }

        [StringLength(5)]
        public string WeightHistory_GainYears { get; set; }

        public decimal? WeightHistory_GainWeight { get; set; }

        [StringLength(100)]
        public string Details_MedicareNumber { get; set; }

        [StringLength(512)]
        public string WeightHistory_GroupDuration { get; set; }

        [StringLength(512)]
        public string WeightHistory_GroupLose { get; set; }

        public DateTime? DeceasedDate { get; set; }

        [StringLength(2048)]
        public string Details_PhotoPath { get; set; }

        [StringLength(50)]
        public string Registry_Antihypertensives { get; set; }

        [StringLength(50)]
        public string Registry_Insulin { get; set; }

        [StringLength(50)]
        public string Registry_SleepApnea { get; set; }

        [StringLength(50)]
        public string Registry_Gerd { get; set; }

        [StringLength(50)]
        public string Registry_Hyperlipidemia { get; set; }

        [StringLength(50)]
        public string Registry_Diabetes { get; set; }

        [StringLength(50)]
        public string Registry_Hypertension { get; set; }

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }

        public bool? Details_DeceasedPrimaryProcedure { get; set; }

        [StringLength(2048)]
        public string Details_DeceasedNote { get; set; }
    }
}
