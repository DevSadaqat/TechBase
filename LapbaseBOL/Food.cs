using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LapbaseBOL
{    
    [Table("lbd.Food")]
    public class Food : BaseClass
    {
        public long ID { get; set; }

        [StringLength(30)]
        public string FoodName { get; set; }

        [StringLength(30)]
        public string MealType { get; set; }

        [StringLength(30)]
        public string Quantity { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] IntakeDate { get; set; }

        public long PatientID { get; set; }

        public long OrganizationCode { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual FoodItem FoodItem { get; set; }

    }
}
