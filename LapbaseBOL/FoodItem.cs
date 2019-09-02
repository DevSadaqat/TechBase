using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace LapbaseBOL
{
    [Table("lbd.FoodItem")]
    public partial class FoodItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodItem()
        {
            Foods = new HashSet<Food>();
        }

        public long ID { get; set; }

        [StringLength(30)]
        public string FoodName { get; set; }

        [StringLength(30)]
        public string MealType { get; set; }

        [StringLength(20)]
        public string Calories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Food> Foods { get; set; }
    }
}
