namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("BSR.BSROrganization")]
    public partial class BSROrganization
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public bool? IsActive { get; set; }

        public int? DoctorID { get; set; }
    }
}
