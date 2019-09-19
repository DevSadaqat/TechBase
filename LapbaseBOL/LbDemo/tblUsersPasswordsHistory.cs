namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblUsersPasswordsHistory")]
    public partial class tblUsersPasswordsHistory
    {
        [Key]
        public int tblUsersPasswordsHistory_ID { get; set; }

        public int UserPracticeCode { get; set; }

        [Required]
        [MaxLength(50)]
        public byte[] OldPassword { get; set; }

        public DateTime OldActivateDate { get; set; }
    }
}
