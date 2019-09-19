namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientPathologyData")]
    public partial class tblPatientPathologyData
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PathologyID { get; set; }

        public DateTime? PathologyDataDate { get; set; }

        public int SectionID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string TestID { get; set; }

        [StringLength(100)]
        public string TestName { get; set; }

        public string TestValue { get; set; }

        [StringLength(100)]
        public string TestUnit { get; set; }

        [StringLength(100)]
        public string TestRange { get; set; }

        [StringLength(100)]
        public string TestStatus { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }
    }
}
