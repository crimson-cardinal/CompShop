using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CompShop.Storage_Models_
{
    public class TovarType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int NomerTipaTovara { get; set; }
        [Required]
        public string TipTovara { get; set; }

    }
}
