namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblUSERS")]
    public partial class tblUSER
    {
        [Key]
        public int UserPracticeCode { get; set; }

        [Required]
        [StringLength(25)]
        public string USERID { get; set; }

        [Required]
        [MaxLength(50)]
        public byte[] USERPW { get; set; }

        public int PERMISSION_FLAG { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_SIRNAME { get; set; }

        [StringLength(10)]
        public string LANGUAGE_CODE { get; set; }

        [StringLength(10)]
        public string CultureInfo { get; set; }

        public DateTime ActivateDate { get; set; }

        [Required]
        [StringLength(3)]
        public string PermissionLevel { get; set; }

        public int? SurgeonID { get; set; }

        public bool? ShowLog { get; set; }

        public bool? ShowRegistry { get; set; }

        public bool? ShowDownloadExcelGraph { get; set; }

        public bool? UserMustChangePasswordFlag { get; set; }

        [StringLength(25)]
        public string MobileNumber { get; set; }
    }
}
