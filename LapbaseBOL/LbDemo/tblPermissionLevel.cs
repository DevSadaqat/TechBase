namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPermissionLevel")]
    public partial class tblPermissionLevel
    {
        [Key]
        [StringLength(3)]
        public string PermissionLvl { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int Rank { get; set; }
    }
}
