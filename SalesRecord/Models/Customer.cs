using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesRecord.Models
{
    public class Customer
    {
        [Key]
        public int CId { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        public string CName { get; set; }

        [DisplayName("Address")]
        public string CAdress { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public double Phone { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}