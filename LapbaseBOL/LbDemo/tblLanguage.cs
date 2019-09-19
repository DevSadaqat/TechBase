namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblLanguage
    {
        [Key]
        [StringLength(10)]
        public string Language_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Language_Name { get; set; }

        public byte? DefaultLanguage { get; set; }

        [Required]
        [StringLength(10)]
        public string CultureInfo { get; set; }

        [StringLength(3)]
        public string Direction { get; set; }

        public bool Enabled { get; set; }
    }
}
