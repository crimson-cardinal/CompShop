using CompShop.Storage_Models_.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CompShop.Storage_Models_
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public string Tovar { get; set; }
        [Required]
        public TovarType TipTovara { get; set; }
        [Required]
        public Buyer Name { get; set; }
        [Required]
        public Buyer SurName { get; set; }


    }
}
