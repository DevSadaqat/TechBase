namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblReferringDoctor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string RefDrId { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string Title { get; set; }

        public byte UseFirst { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string Suburb { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        public bool? Hide { get; set; }
    }
}
