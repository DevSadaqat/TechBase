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
            public Int32 Age { get; set; }
            public string Street { get; set; }
            public string Suburb { get; set; }
            public string State { get; set; }
            public string Postcode { get; set; }
            public string SuburbValue { get; set; }
            public string HomePhone { get; set; }
            public string WorkPhone { get; set; }
            public string Birthdate { get; set; }          
            public string RefDrName1 { get; set; }
            public decimal? Height { get; set; }
            public decimal? StartWeight { get; set; }
            public DateTime? StartWeightDate { get; set; }
            public decimal? IdealWeight { get; set; }
            public decimal? CurrentWeight { get; set;}
            public decimal? TargetWeight { get; set; }
            public decimal? StartBMIWeight { get; set; }
            public decimal? BMIHeight { get; set; }
            public decimal? OpBMIWeight { get; set; }
            public decimal? BMI { get; set; }

        }
}

