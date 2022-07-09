using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.ManolisModels
{
    internal class Model
    {
        public int ModelId { get; set; }
        public Product Details { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool OutOfStock { get; set; }
        public string Descript { get; set; }
        


    }
}
