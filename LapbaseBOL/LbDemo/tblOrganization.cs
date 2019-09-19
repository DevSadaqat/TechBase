namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblOrganization")]
    public partial class tblOrganization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [Required]
        [StringLength(100)]
        public string OrgDomainName { get; set; }

        public decimal? VersionNo { get; set; }

        public int? ApplicationMode { get; set; }

        public bool? IsActivated { get; set; }

        [StringLength(10)]
        public string LanguageCode { get; set; }

        [StringLength(10)]
        public string CultureInfo { get; set; }

        public bool SuperBill { get; set; }

        public bool DataClamp { get; set; }

        [StringLength(5)]
        public string DefaultSort { get; set; }

        public bool? EMR { get; set; }

        [StringLength(100)]
        public string SubmitData { get; set; }

        [StringLength(20)]
        public string PracticeBoldCode { get; set; }

        [StringLength(250)]
        public string AdminEmail { get; set; }

        public bool InactiveFlag { get; set; }

        [StringLength(50)]
        public string IFSOCode { get; set; }

        public bool? Export { get; set; }

        public bool? BSRExport { get; set; }

        [StringLength(255)]
        public string connectionString { get; set; }
    }
}
