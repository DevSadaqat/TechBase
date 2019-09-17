namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblOrganizationBiochemistry")]
    public partial class tblOrganizationBiochemistry
    {
        [Key]
        public int OrgBiochemId { get; set; }

        public int? OrganizationCode { get; set; }

        [StringLength(1024)]
        public string BiochemistryCode { get; set; }
    }
}
