namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblERRORS")]
    public partial class tblERROR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblError_Code { get; set; }

        public int? Error_Type { get; set; }

        [StringLength(50)]
        public string Alias_Name { get; set; }

        [StringLength(100)]
        public string Error_Desc_English { get; set; }

        [StringLength(100)]
        public string Error_Desc_Arabic { get; set; }

        [StringLength(100)]
        public string Error_Desc_Spanish { get; set; }
    }
}
