using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LapbaseBOL
{
    [Table("lbd.Weight")]
    public class Weight : BaseClass
    {
        public long ID { get; set; }

        public decimal? WeightValue { get; set; }

        public long PatientID { get; set; }

        public long OrganizationCode { get; set; }

        public decimal? BMI { get; set; }
    }
}
