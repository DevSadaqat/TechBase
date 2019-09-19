namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientPathology")]
    public partial class tblPatientPathology
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
        public int PathologyID { get; set; }

        [StringLength(100)]
        public string PathologyBaseline { get; set; }

        public DateTime? PathologyDate { get; set; }

        public DateTime? DateDeleted { get; set; }

        [StringLength(50)]
        public string DeletedByUser { get; set; }

        [StringLength(100)]
        public string RefDr { get; set; }

        public bool Review { get; set; }
    }
}
