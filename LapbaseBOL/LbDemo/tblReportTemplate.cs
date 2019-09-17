namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblReportTemplate
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ReportTemplateName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        public int OrganizationCode { get; set; }

        public int? TemplateId { get; set; }
    }
}
