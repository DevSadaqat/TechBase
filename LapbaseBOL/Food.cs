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

        [Required]
        [StringLength(30)]
        public string FoodName { get; set; }

        [StringLength(30)]
        public string MealType { get; set; }

        [StringLength(30)]
        public string Quantity { get; set; }

        public DateTime? IntakeDate { get; set; }

        public long PatientID { get; set; }

        public long OrganizationCode { get; set; }


        public virtual FoodItem FoodItem { get; set; }

    }
}
