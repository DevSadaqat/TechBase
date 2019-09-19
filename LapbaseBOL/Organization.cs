using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LapbaseBOL
{   
    [Table("lbd.Organization")]
    public class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            SystemDetails = new HashSet<SystemDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrganizationCode { get; set; }

        [StringLength(50)]
        public string OrgDomainName { get; set; }

        [StringLength(10)]
        public string LanguageCode { get; set; }

        [StringLength(10)]
        public string CulturalInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemDetail> SystemDetails { get; set; }
    }
}
