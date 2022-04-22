using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesRecord.Models
{
    public class Sale
    {
        [Key]
        public int SId { get; set; }

        [ForeignKey("Product")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter greater than 0 number")]
        public int PId { get; set; }

        [ForeignKey("Customer")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter greater than 0 number")]
        public int CId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter greater than 0 number")]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        //public virtual ICollection<Customer> Customer { get; set; }
        //public virtual ICollection<Product> Product { get; set; }



    }
}