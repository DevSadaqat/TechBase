namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblTempWeightLossReport")]
    public partial class tblTempWeightLossReport
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizationCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupByMonthNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientID { get; set; }

        [StringLength(20)]
        public string CustomPatientID { get; set; }

        [StringLength(100)]
        public string PatientName { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        public int? AGE { get; set; }

        public DateTime? DateSeen { get; set; }

        [StringLength(25)]
        public string LapbandDate { get; set; }

        public int? VisitMonthsSinceOperation { get; set; }

        public decimal? StartEW { get; set; }

        [StringLength(5)]
        public string WeightMeasurment { get; set; }

        public decimal? StartWeight { get; set; }

        public decimal? IdealWeight { get; set; }

        public decimal? Weight { get; set; }

        public decimal? InitBMI { get; set; }

        public decimal? BMI { get; set; }

        public decimal? EWLGroup025 { get; set; }

        public decimal? EWLGroup2550 { get; set; }

        public decimal? EWLGroup5075 { get; set; }

        public decimal? EWLGroup75100 { get; set; }

        public int? EWLL { get; set; }

        [StringLength(10)]
        public string strEWLL { get; set; }

        [StringLength(255)]
        public string HospitalName { get; set; }

        [StringLength(255)]
        public string DoctorName { get; set; }

        [StringLength(255)]
        public string HospitalName_Title { get; set; }

        [StringLength(255)]
        public string DoctorName_Title { get; set; }

        public DateTime? InitFilBirthdate { get; set; }

        public int? InitFilBMI { get; set; }

        [StringLength(50)]
        public string InitFilGroup { get; set; }

        [StringLength(50)]
        public string InitFilSurgeryType { get; set; }

        [StringLength(50)]
        public string InitFilLapbandType { get; set; }

        [StringLength(50)]
        public string InitFilApproach { get; set; }

        [StringLength(50)]
        public string InitFilCategory { get; set; }

        [StringLength(50)]
        public string InitFilLapbandSize { get; set; }

        public int? InitFilSurgeonId { get; set; }

        [StringLength(50)]
        public string InitFilHospitalCode { get; set; }

        [StringLength(50)]
        public string InitFilRegionID { get; set; }

        public DateTime? InitFilLapBandDate { get; set; }
    }
}
