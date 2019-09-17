namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblUserAccessPermission")]
    public partial class tblUserAccessPermission
    {
        public int tblUserAccessPermissionID { get; set; }

        public int? tblAPPSCHEMA_CODE { get; set; }

        public int? AccessPermissionCode { get; set; }

        public int OrganizationCode { get; set; }

        public int UserPracticeCode { get; set; }
    }
}
