namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblUserActivationCode")]
    public partial class tblUserActivationCode
    {
        public int ID { get; set; }

        public int? UserPracticeCode { get; set; }

        public long? ActivationCode { get; set; }

        public DateTime? EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        public bool? IsExpired { get; set; }
    }
}
