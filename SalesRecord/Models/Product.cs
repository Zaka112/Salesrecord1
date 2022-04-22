using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesRecord.Models
{
    public class Product
    {
        [Key]
        public int PId { get; set; }

        [DisplayName("Product Name")]
        [Required]
        public string PName { get; set; }

        [DisplayName("Product's Price")]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter greater than 0 number")]
        [Required]
        public double Price { get; set; }

        [DisplayName("Quantity Available")]
        [Required]
        public double PRemaining { get; set; }

        //  public virtual ICollection<Customer> Customer { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }



    }
}
