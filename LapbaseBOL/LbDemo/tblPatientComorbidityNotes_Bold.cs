namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientComorbidityNotes_Bold
    {
        [Key]
        [Column(Order = 0)]
        public int tblComorbidityNotes_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        public int PatientID { get; set; }

        public int ConsultID { get; set; }

        public string CVS { get; set; }

        public string MET { get; set; }

        public string PUL { get; set; }

        public string GAS { get; set; }

        public string MUS { get; set; }

        public string REPRD { get; set; }

        public string PSY { get; set; }

        public string GEN { get; set; }
    }
}
