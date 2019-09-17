namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblSystemNormal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Code { get; set; }

        [StringLength(25)]
        public string TestType { get; set; }

        [StringLength(5)]
        public string ImperialLow { get; set; }

        [StringLength(5)]
        public string ImperialLow_F { get; set; }

        [StringLength(50)]
        public string ImperialHigh { get; set; }

        [StringLength(50)]
        public string ImperialHigh_F { get; set; }

        [StringLength(5)]
        public string ImperialUnits { get; set; }

        [StringLength(5)]
        public string MetricLow { get; set; }

        [StringLength(5)]
        public string MetricLow_F { get; set; }

        [StringLength(5)]
        public string MetricHigh { get; set; }

        [StringLength(5)]
        public string MetricHigh_F { get; set; }

        [StringLength(10)]
        public string MetricUnits { get; set; }

        [StringLength(10)]
        public string ConversionImpToMetric { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
