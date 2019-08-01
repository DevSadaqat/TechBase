namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lbd.Weight")]
    public partial class Weight 
    {
        public long ID { get; set; }

        public decimal? WeightValue { get; set; }

        public long PatientID { get; set; }

        public long OrganizationCode { get; set; }

        public virtual Patient Patient { get; set; }

        public DateTime CreatedAt { get; set; }
        public String CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public String ModifiedBy { get; set; }
    }
}
