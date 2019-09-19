namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblAppSchemaListItem
    {
        public int ID { get; set; }

        public int tblAPPSCHEMA_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string Field_ID { get; set; }

        public byte List_Value { get; set; }

        [StringLength(50)]
        public string List_Text_English { get; set; }

        [StringLength(50)]
        public string List_Text_Arabic { get; set; }

        [StringLength(50)]
        public string List_Text_Spanish { get; set; }

        [StringLength(50)]
        public string List_Text_Portugese { get; set; }
    }
}
