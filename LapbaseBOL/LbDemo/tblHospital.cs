namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblHospital
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [Key]
        [Column("Hospital Id", Order = 1)]
        [StringLength(6)]
        public string Hospital_Id { get; set; }

        [Column("Hospital Name")]
        [Required]
        [StringLength(50)]
        public string Hospital_Name { get; set; }

        [StringLength(30)]
        public string Street { get; set; }

        [StringLength(20)]
        public string Suburb { get; set; }

        [StringLength(4)]
        public string PostCode { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(12)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string HospitalBoldCode { get; set; }

        [Column("Region Id")]
        [StringLength(6)]
        public string Region_Id { get; set; }
    }
}
