namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblFileCategory")]
    public partial class tblFileCategory
    {
        [Key]
        public int Type_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type_Name { get; set; }

        public int Order_No { get; set; }

        public int Facility_ID { get; set; }
    }
}
