namespace EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("lbd.User")]
    public partial class User
    {
        [StringLength(30)]
        public string ID { get; set; }

        public long OrganizationCode { get; set; }

        public long PatientID { get; set; }

        public int? IsValid { get; set; }

        public DateTime? ValidToDate { get; set; }

        public DateTime? ValidFromDate { get; set; }

        public int? IsDeleted { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
