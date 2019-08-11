using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LapbaseBOL
{    
    [Table("lbd.SystemDetails")]
    public partial class SystemDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SystemId { get; set; }

        public int? Imperial { get; set; }

        public long OrganizationCode { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
