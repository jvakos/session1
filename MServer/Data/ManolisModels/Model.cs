using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.ManolisModels
{
    internal class Model
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModelId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool OutOfStock { get; set; }
        public string Descript { get; set; }
        


    }
}
