namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientConsult_Bold_Notes
    {
        [Key]
        [Column(Order = 0)]
        public int tblPatientConsultComorbidityNotes_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int? PatientID { get; set; }

        public int? ConsultID { get; set; }

        public string CVS_Hypertension_Notes { get; set; }

        public string CVS_Congestive_Notes { get; set; }

        public string CVS_Ischemic_Notes { get; set; }

        public string CVS_Angina_Notes { get; set; }

        public string CVS_Peripheral_Notes { get; set; }

        public string CVS_Lower_Notes { get; set; }

        public string CVS_DVT_Notes { get; set; }

        public string MET_Glucose_Notes { get; set; }

        public string MET_Lipids_Notes { get; set; }

        public string MET_Gout_Notes { get; set; }

        public string PUL_Obstructive_Notes { get; set; }

        public string PUL_Obesity_Notes { get; set; }

        public string PUL_PulHypertension_Notes { get; set; }

        public string PUL_Asthma_Notes { get; set; }

        public string GAS_Gerd_Notes { get; set; }

        public string GAS_Cholelithiasis_Notes { get; set; }

        public string GAS_Liver_Notes { get; set; }

        public string MUS_BackPain_Notes { get; set; }

        public string MUS_Musculoskeletal_Notes { get; set; }

        public string MUS_Fibromyalgia_Notes { get; set; }

        public string REPRD_Polycystic_Notes { get; set; }

        public string REPRD_Menstrual_Notes { get; set; }

        public string PSY_Impairment_Notes { get; set; }

        public string PSY_Depression_Notes { get; set; }

        public string PSY_MentalHealth_Notes { get; set; }

        public string PSY_Alcohol_Notes { get; set; }

        public string PSY_Tobacoo_Notes { get; set; }

        public string PSY_Abuse_Notes { get; set; }

        public string GEN_Stress_Notes { get; set; }

        public string GEN_Cerebri_Notes { get; set; }

        public string GEN_Hernia_Notes { get; set; }

        public string GEN_Functional_Notes { get; set; }

        public string GEN_Skin_Notes { get; set; }

        public string Extra_Comorbidity { get; set; }

        public string GEN_RenalInsuff_Notes { get; set; }

        public string GEN_RenalFail_Notes { get; set; }

        public string GEN_Steroid_Notes { get; set; }

        public string GEN_Therapeutic_Notes { get; set; }

        public string GEN_PrevPCISurgery_Notes { get; set; }

        public bool? Comorbidity_Review { get; set; }

        public string ACS_Smoke_Notes { get; set; }

        public string ACS_Oxy_Notes { get; set; }

        public string ACS_Embo_Notes { get; set; }

        public string ACS_Copd_Notes { get; set; }

        public string ACS_Cpap_Notes { get; set; }

        public string ACS_Gerd_Notes { get; set; }

        public string ACS_Gal_Notes { get; set; }

        public string ACS_Muscd_Notes { get; set; }

        public string ACS_Pain_Notes { get; set; }

        public string ACS_Meds_Notes { get; set; }

        public string ACS_Surg_Notes { get; set; }

        public string ACS_Mob_Notes { get; set; }

        public string ACS_Uri_Notes { get; set; }

        public string ACS_Myo_Notes { get; set; }

        public string ACS_Pci_Notes { get; set; }

        public string ACS_Csurg_Notes { get; set; }

        public string ACS_Lipid_Notes { get; set; }

        public string ACS_Hyper_Notes { get; set; }

        public string ACS_Dvt_Notes { get; set; }

        public string ACS_Venous_Notes { get; set; }

        public string ACS_Health_Notes { get; set; }

        public string ACS_Diab_Notes { get; set; }

        public string ACS_Obese_Notes { get; set; }

        public string ACS_General_Notes { get; set; }

        public string ACS_Sho_Notes { get; set; }

        public string ACS_Fat_Notes { get; set; }
    }
}
