using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.ManolisModels
{
    internal class CategoryModel
    {
        public Product Details { get; set; }
        public int CategoryId { get; set; }
        public decimal Qnt { get; set; }
        public decimal Price { get; set; }
        public string OutOfStock { get; set; }
        public string Descript { get; set; }
        


    }
}
