namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblAppSchemaField
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tblAPPSCHEMA_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Field_ID { get; set; }

        [StringLength(1024)]
        public string Field_Name_English { get; set; }

        [StringLength(1024)]
        public string Field_Name_ARABIC { get; set; }

        [StringLength(1024)]
        public string Field_Name_Spanish { get; set; }

        [StringLength(1024)]
        public string Field_Name_Australian { get; set; }

        [StringLength(1024)]
        public string Field_Name_German { get; set; }

        [StringLength(1024)]
        public string Field_Name_French { get; set; }

        [StringLength(1024)]
        public string Field_Name_Portugese { get; set; }
    }
}
