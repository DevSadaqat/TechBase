namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientACSForm")]
    public partial class tblPatientACSForm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }

        public DateTime? Form1 { get; set; }

        public DateTime? Form2 { get; set; }

        public DateTime? Form3 { get; set; }

        public DateTime? Form4 { get; set; }

        public DateTime? Form5 { get; set; }

        public DateTime? Form6 { get; set; }

        public DateTime? Form7 { get; set; }

        public DateTime? Form8 { get; set; }

        public DateTime? Form9 { get; set; }
    }
}
