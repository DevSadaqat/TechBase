namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientConsultLog_Bold
    {
        [Key]
        public int tblPatientConsultComorbidityLog_ID { get; set; }

        public int tblPatientConsultComorbidity_ID { get; set; }

        public int OrganizationCode { get; set; }

        public int? PatientID { get; set; }

        public int? ConsultID { get; set; }

        [StringLength(10)]
        public string CVS_Hypertension { get; set; }

        [StringLength(10)]
        public string CVS_Congestive { get; set; }

        [StringLength(10)]
        public string CVS_Ischemic { get; set; }

        [StringLength(10)]
        public string CVS_Angina { get; set; }

        [StringLength(10)]
        public string CVS_Peripheral { get; set; }

        [StringLength(10)]
        public string CVS_Lower { get; set; }

        [StringLength(10)]
        public string CVS_DVT { get; set; }

        [StringLength(10)]
        public string MET_Glucose { get; set; }

        [StringLength(10)]
        public string MET_Lipids { get; set; }

        [StringLength(10)]
        public string MET_Gout { get; set; }

        [StringLength(10)]
        public string PUL_Obstructive { get; set; }

        [StringLength(10)]
        public string PUL_Obesity { get; set; }

        [StringLength(10)]
        public string PUL_PulHypertension { get; set; }

        [StringLength(10)]
        public string PUL_Asthma { get; set; }

        [StringLength(10)]
        public string GAS_Gerd { get; set; }

        [StringLength(10)]
        public string GAS_Cholelithiasis { get; set; }

        [StringLength(10)]
        public string GAS_Liver { get; set; }

        [StringLength(10)]
        public string MUS_BackPain { get; set; }

        [StringLength(10)]
        public string MUS_Musculoskeletal { get; set; }

        [StringLength(10)]
        public string MUS_Fibromyalgia { get; set; }

        [StringLength(10)]
        public string REPRD_Polycystic { get; set; }

        [StringLength(10)]
        public string REPRD_Menstrual { get; set; }

        [StringLength(10)]
        public string PSY_Impairment { get; set; }

        [StringLength(10)]
        public string PSY_Depression { get; set; }

        [StringLength(10)]
        public string PSY_MentalHealth { get; set; }

        [StringLength(10)]
        public string PSY_Alcohol { get; set; }

        [StringLength(10)]
        public string PSY_Tobacoo { get; set; }

        [StringLength(10)]
        public string PSY_Abuse { get; set; }

        [StringLength(10)]
        public string GEN_Stress { get; set; }

        [StringLength(10)]
        public string GEN_Cerebri { get; set; }

        [StringLength(10)]
        public string GEN_Hernia { get; set; }

        [StringLength(10)]
        public string GEN_Functional { get; set; }

        [StringLength(10)]
        public string GEN_Skin { get; set; }

        [StringLength(10)]
        public string GEN_RenalInsuff { get; set; }

        [StringLength(10)]
        public string GEN_RenalFail { get; set; }

        [StringLength(10)]
        public string GEN_Steroid { get; set; }

        [StringLength(10)]
        public string GEN_Therapeutic { get; set; }

        [StringLength(10)]
        public string GEN_PrevPCISurgery { get; set; }

        [StringLength(50)]
        public string VitaminList { get; set; }

        [StringLength(255)]
        public string Vitamin_Description { get; set; }

        public DateTime? PatientVisitDate { get; set; }

        public decimal PatientHeight { get; set; }

        public decimal PatientWeight { get; set; }

        public bool Bold_Flag { get; set; }

        [StringLength(50)]
        public string BoldVisitID { get; set; }

        [StringLength(50)]
        public string SupportGroup { get; set; }

        [StringLength(50)]
        public string ACS_Smoke { get; set; }

        [StringLength(50)]
        public string ACS_Oxy { get; set; }

        [StringLength(50)]
        public string ACS_Embo { get; set; }

        [StringLength(50)]
        public string ACS_Copd { get; set; }

        [StringLength(50)]
        public string ACS_Cpap { get; set; }

        [StringLength(50)]
        public string ACS_Gerd { get; set; }

        [StringLength(50)]
        public string ACS_Gal { get; set; }

        [StringLength(50)]
        public string ACS_Muscd { get; set; }

        [StringLength(50)]
        public string ACS_Pain { get; set; }

        [StringLength(50)]
        public string ACS_Meds { get; set; }

        [StringLength(50)]
        public string ACS_Surg { get; set; }

        [StringLength(50)]
        public string ACS_Mob { get; set; }

        [StringLength(50)]
        public string ACS_Uri { get; set; }

        [StringLength(50)]
        public string ACS_Myo { get; set; }

        [StringLength(50)]
        public string ACS_Pci { get; set; }

        [StringLength(50)]
        public string ACS_Csurg { get; set; }

        [StringLength(50)]
        public string ACS_Lipid { get; set; }

        [StringLength(50)]
        public string ACS_Hyper { get; set; }

        [StringLength(50)]
        public string ACS_Dvt { get; set; }

        [StringLength(50)]
        public string ACS_Venous { get; set; }

        [StringLength(50)]
        public string ACS_Health { get; set; }

        [StringLength(50)]
        public string ACS_Diab { get; set; }

        [StringLength(50)]
        public string ACS_Obese { get; set; }

        public string AUS_EndDiab { get; set; }

        public string AUS_EndThy { get; set; }

        public string AUS_EndOtherName { get; set; }

        public string AUS_EndOtherDesc { get; set; }

        public string AUS_PulAsthma { get; set; }

        public string AUS_PulApnea { get; set; }

        public string AUS_PulEmb { get; set; }

        public string AUS_PulOtherName { get; set; }

        public string AUS_PulOtherDesc { get; set; }

        public string AUS_GasRef { get; set; }

        public string AUS_GasUlc { get; set; }

        public string AUS_GasGall { get; set; }

        public string AUS_GasHep { get; set; }

        public string AUS_GasOtherName { get; set; }

        public string AUS_GasOtherDesc { get; set; }

        public string AUS_CvsIsc { get; set; }

        public string AUS_CvsBlood { get; set; }

        public string AUS_CvsCol { get; set; }

        public string AUS_CvsDVT { get; set; }

        public string AUS_CvsVen { get; set; }

        public string AUS_CvsAnti { get; set; }

        public string AUS_CvsOtherName { get; set; }

        public string AUS_CvsOtherDesc { get; set; }

        public string AUS_PsyDep { get; set; }

        public string AUS_PsyAnx { get; set; }

        public string AUS_PsyPhob { get; set; }

        public string AUS_PsyEat { get; set; }

        public string AUS_PsyHead { get; set; }

        public string AUS_PsyStroke { get; set; }

        public string AUS_PsyOtherName { get; set; }

        public string AUS_PsyOtherDesc { get; set; }

        public string AUS_MuscBack { get; set; }

        public string AUS_MuscHip { get; set; }

        public string AUS_MuscKnee { get; set; }

        public string AUS_MuscFeet { get; set; }

        public string AUS_MuscFibr { get; set; }

        public string AUS_MuscOtherName { get; set; }

        public string AUS_MuscOtherDesc { get; set; }

        public string AUS_GenInf { get; set; }

        public string AUS_GenRen { get; set; }

        public string AUS_GenUri { get; set; }

        public string AUS_OtherPso { get; set; }

        public string AUS_OtherSkin { get; set; }

        public string AUS_OtherCancer { get; set; }

        public string AUS_OtherAnemia { get; set; }

        public string AUS_OtherOtherName { get; set; }

        public string AUS_OtherOtherDesc { get; set; }

        public string MedicationList { get; set; }

        [StringLength(50)]
        public string ACS_Sho { get; set; }

        [StringLength(50)]
        public string ACS_Fat { get; set; }

        public int? LogUserPracticeCode { get; set; }

        public DateTime? LogDateTime { get; set; }
    }
}
