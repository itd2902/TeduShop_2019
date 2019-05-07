using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [MaxLength(250)]
        [Required]
        public string CustomerAddress { get; set; }

        [MaxLength(250)]
        [Required]
        public string CustomerEmail { get; set; }

        [MaxLength(50)]
        [Required]
        public string CustomerMobile { get; set; }

        [MaxLength(250)]
        public string CustomerMessage { get; set; }

        [MaxLength(250)]
        public string PaymentMethod { get; set; }

        [MaxLength(50)]
        [Required]
        public string PaymentStatus { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}