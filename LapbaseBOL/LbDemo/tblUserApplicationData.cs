namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblUserApplicationData")]
    public partial class tblUserApplicationData
    {
        [StringLength(100)]
        public string SessionID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        public int? PatientID { get; set; }

        public int? CunsultID { get; set; }

        public int? OperationID { get; set; }

        public int? ComplicationID { get; set; }

        public bool? Imperial { get; set; }

        [StringLength(10)]
        public string LanguageCode { get; set; }

        [StringLength(10)]
        public string CultureInfo { get; set; }

        [StringLength(3)]
        public string Direction { get; set; }

        public bool? VisitWeeksFlag { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }
    }
}
