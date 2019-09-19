namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblComplications_Bold
    {
        [Key]
        [Column(Order = 0)]
        public int tblComplications_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }

        public int PatientId { get; set; }

        public int ComplicationNum { get; set; }

        public DateTime? ComplicationDate { get; set; }

        [StringLength(10)]
        public string ComplicationCode { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [StringLength(255)]
        public string AdverseSurgery { get; set; }

        public int DoctorID { get; set; }

        public bool Bold_Flag { get; set; }

        [StringLength(50)]
        public string BoldAdverseEventID { get; set; }
    }
}
