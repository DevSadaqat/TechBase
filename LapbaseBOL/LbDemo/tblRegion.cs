namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblRegion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [Key]
        [Column("Region Id", Order = 1)]
        [StringLength(6)]
        public string Region_Id { get; set; }

        [Column("Region Name")]
        [Required]
        [StringLength(50)]
        public string Region_Name { get; set; }
    }
}
