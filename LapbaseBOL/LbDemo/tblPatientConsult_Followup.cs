namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblPatientConsult_Followup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column("Patient Id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Patient_Id { get; set; }

        [StringLength(20)]
        public string FollowupAppointment { get; set; }

        [StringLength(20)]
        public string FollowupPhone { get; set; }

        [StringLength(20)]
        public string FollowupLetterPatient { get; set; }

        [StringLength(20)]
        public string FollowupLetterPhysician { get; set; }

        [StringLength(20)]
        public string FollowupTransfer { get; set; }

        [StringLength(20)]
        public string FollowupRefuse { get; set; }

        [StringLength(20)]
        public string FollowupLost { get; set; }

        [StringLength(1024)]
        public string FollowupTransferName { get; set; }

        public bool? FollowupDoNotContact { get; set; }

        public DateTime? FollowupDate { get; set; }
    }
}
