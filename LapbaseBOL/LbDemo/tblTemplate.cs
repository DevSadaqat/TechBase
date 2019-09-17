namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblTemplate
    {
        [Key]
        [Column(Order = 0)]
        public int TemplateId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string TemplateName { get; set; }

        public string TemplateText { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }
    }
}
