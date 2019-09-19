namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblPatientBSForm")]
    public partial class tblPatientBSForm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }

        public DateTime? Reg1Y1 { get; set; }

        public DateTime? Reg2Y1 { get; set; }

        public DateTime? Reg2Y2 { get; set; }

        public DateTime? Reg2Y3 { get; set; }

        public DateTime? Reg2Y4 { get; set; }

        public DateTime? Reg2Y5 { get; set; }

        public DateTime? Reg2Y6 { get; set; }

        public DateTime? Reg2Y7 { get; set; }

        public DateTime? Reg2Y8 { get; set; }
    }
}
