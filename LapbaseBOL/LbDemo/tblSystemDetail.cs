namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblSystemDetail
    {
        [Key]
        [Column(Order = 0)]
        public int SystemId { get; set; }

        [StringLength(255)]
        public string SystemName { get; set; }

        [StringLength(1)]
        public string SystemType { get; set; }

        public DateTime? DateInstalled { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(10)]
        public string CountryCode { get; set; }

        [StringLength(2)]
        public string SystemCode { get; set; }

        public bool Imperial { get; set; }

        [StringLength(5)]
        public string WOScale { get; set; }

        public decimal TargetBMI { get; set; }

        public decimal ReferenceBMI { get; set; }

        [StringLength(200)]
        public string BackUpLocation { get; set; }

        [StringLength(3)]
        public string MFU3 { get; set; }

        [StringLength(3)]
        public string MFU6 { get; set; }

        [StringLength(3)]
        public string MFU12 { get; set; }

        [StringLength(3)]
        public string FU1Y { get; set; }

        [StringLength(3)]
        public string FU2Y { get; set; }

        [StringLength(3)]
        public string FU3Y { get; set; }

        [StringLength(3)]
        public string FU4Y { get; set; }

        public short FU1 { get; set; }

        public short FU2 { get; set; }

        public short FU3 { get; set; }

        public short RD1 { get; set; }

        public short RD2 { get; set; }

        public short CV { get; set; }

        public short UseRace { get; set; }

        [StringLength(255)]
        public string EWPerCent { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(30)]
        public string CreatedByUser { get; set; }

        [StringLength(30)]
        public string CreatedByComputer { get; set; }

        public DateTime? LastModified { get; set; }

        [StringLength(30)]
        public string ModifiedByUser { get; set; }

        [StringLength(30)]
        public string ModifiedByComputer { get; set; }

        public short? ComordityVisitMonths { get; set; }

        public bool IdealOnBMI { get; set; }

        public bool FUPNotes { get; set; }

        public bool FUCom { get; set; }

        public bool FUinv { get; set; }

        public bool PatCOM { get; set; }

        public bool PatInv { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPracticeCode { get; set; }

        public int VisitWeeksFlag { get; set; }

        public int? OrganizationCode { get; set; }

        public int? LetterheadMargin { get; set; }

        public bool? AutoSave { get; set; }

        [StringLength(100)]
        public string FacilityName { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(40)]
        public string Suburb { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(10)]
        public string PostCode { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Fax { get; set; }

        public short? TargetExcessWeight { get; set; }
    }
}
