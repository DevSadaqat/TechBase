namespace LapbaseBOL.LbDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("tblDocumentEventCategory")]
    public partial class tblDocumentEventCategory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EventCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string EventName { get; set; }
    }
}
