namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblEMRNote
    {
        [Key]
        public int NotesID { get; set; }

        [Required]
        public string Notes { get; set; }

        public int OrganizationCode { get; set; }
    }
}
