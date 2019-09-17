using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LapbaseBOL.LbDemo.SPClasses
{
        public class PatientDemographic
        {
            // public  PatientCustomID { get; set; }
            [Key]
            public int PatientID { get; set; }
            public string Surname { get; set; }
            public string Firstname { get; set; }
            public Int16 Title { get; set; }
            public DateTime? Birthdate { get; set; }
            public string Sex { get; set; }
            public string Race { get; set; }
            public DateTime? ConsultationDate { get; set; }
            public string MedicalSummary { get; set; }
            public string Street { get; set; }
            public string Suburb { get; set; }
            public string State { get; set; }
            public string Postcode { get; set; }
            public string RefDrId1 { get; set; }
            public string RefDrId2 { get; set; }
            public string RefDrId3 { get; set; }
            public string RefDrDate1 { get; set; }
            public string RefDrDate2 { get; set; }
            public string RefDrDate3 { get; set; }
            public string RefDrDuration1 { get; set; }
            public string RefDrDuration2 { get; set; }
            public string RefDrDuration3 { get; set; }
            public string RefDrStatus1 { get; set; }
            public string RefDrStatus2 { get; set; }
            public string RefDrStatus3 { get; set; }
            public string EmailAddress { get; set; }
            public string HomePhone { get; set; }
            public string WorkPhone { get; set; }
            public string MobilePhone { get; set; }
            public string SocialHistory { get; set; }
            public string Occupation { get; set; }
            public string DeceasedDate { get; set; }
            public string DeceasedPrimaryProcedure { get; set; }
            public string DeceasedNote { get; set; }
            public string FamilyStructure { get; set; }
            public string LiveAtHome { get; set; }
            public string PartnerName { get; set; }
            public string NextOfKinName { get; set; }
            public string NextOfKinRelation { get; set; }
            public string NextOfKinAddress { get; set; }
            public string NextOfKinHomePhone { get; set; }
            public string NextOfKinWorkPhone { get; set; }
            public string AddContact1Name { get; set; }
            public string AddContact1Relation { get; set; }
            public string AddContact1Address { get; set; }
            public string AddContact1HomePhone { get; set; }
            public string AddContact1Mobile { get; set; }
            public string AddContact2Name { get; set; }
            public string AddContact2Relation { get; set; }
            public string AddContact2Address { get; set; }
            public string AddContact2HomePhone { get; set; }
            public string AddContact2Mobile { get; set; }
            public string MedicareNumber { get; set; }
            public string EmploymentStatus { get; set; }
            public string EmployerName { get; set; }
            public Boolean HasInsurance { get; set; }
            public string InsuranceNumber { get; set; }
            public Int16 IsCoverProcedure { get; set; }
            public string SecondaryInsurance { get; set; }
            public string TertiaryInsurance { get; set; }
            public Boolean IsPrivateInsurance { get; set; }
            public Boolean IsMedicaid { get; set; }
            public Boolean IsSelfPay { get; set; }
            public Boolean IsGovernmentInsurance { get; set; }
            public Boolean IsMedicare { get; set; }
            public Boolean IsCharity { get; set; }
            public decimal? PreOperativeWeightLoss { get; set; }
            public string DietryWeightLoss { get; set; }
            public Boolean DurationObesity { get; set; }
            public Boolean SmokingCessation { get; set; }
            public Boolean MentalHealthClearance { get; set; }
            public Boolean IQTesting { get; set; }
            public string PreCertification_Other { get; set; }
            public int Surgeon { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string ChartNumber { get; set; }

        
    }
}

