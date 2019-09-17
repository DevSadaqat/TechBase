namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblRole")]
    public partial class tblRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblRoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }
    }
}
