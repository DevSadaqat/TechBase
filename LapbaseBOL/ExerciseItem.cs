using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LapbaseBOL
{

    [Table("lbd.ExerciseItem")]
    public partial class ExerciseItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExerciseItem()
        {
            Exercises = new HashSet<Exercise>();
        }

        [Key]
        [StringLength(30)]
        public string ExerciseName { get; set; }

        [StringLength(30)]
        public string ExerciseType { get; set; }

        [StringLength(20)]
        public string Calories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}
