namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class tblCharacter
    {
        [Key]
        public int tblCharacter_SNo { get; set; }

        [StringLength(10)]
        public string Language_Code { get; set; }

        [StringLength(1)]
        public string Character_Caption { get; set; }

        public short? Character_OrderNo { get; set; }
    }
}
