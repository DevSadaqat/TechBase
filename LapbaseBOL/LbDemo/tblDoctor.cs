namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblDoctor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public int DoctorID { get; set; }

        [StringLength(30)]
        public string Surname { get; set; }

        [StringLength(30)]
        public string Firstname { get; set; }

        [StringLength(4)]
        public string Initial { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(100)]
        public string DoctorName { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Suburb { get; set; }

        [StringLength(10)]
        public string Postcode { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(12)]
        public string Telephone { get; set; }

        [StringLength(12)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Degrees { get; set; }

        [StringLength(100)]
        public string Speciality { get; set; }

        public byte? UseOwnLetterHead { get; set; }

        [StringLength(10)]
        public string PrefSurgeryType { get; set; }

        [StringLength(50)]
        public string PrefApproach { get; set; }

        [StringLength(10)]
        public string PrefCategory { get; set; }

        [StringLength(10)]
        public string PrefGroup { get; set; }

        [StringLength(10)]
        public string CountryCode { get; set; }

        [StringLength(10)]
        public string LapBandCode { get; set; }

        public bool? OtherType { get; set; }

        public bool? IsSurgeon { get; set; }

        public bool? Hide { get; set; }

        [StringLength(20)]
        public string DoctorBoldCode { get; set; }
    }
}
