namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblLogos")]
    public partial class tblLogo
    {
        [Key]
        public int LogoId { get; set; }

        [Required]
        [StringLength(20)]
        public string LogoName { get; set; }

        [StringLength(2048)]
        public string LogoPath { get; set; }

        public int UserPracticeCode { get; set; }

        public int OrganizationCode { get; set; }
    }
}
