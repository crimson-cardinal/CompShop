using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompShop.Storage_Models_
{
    public class VideoCard
    {
        public TovarType NomerTipaTovara { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int VideoMemory { get; set; }
    }
}
