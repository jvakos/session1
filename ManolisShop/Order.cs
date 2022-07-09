using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    internal class Order
    {
        public int UserId { get; set; }
        public DateTime OrderTime { get; set; }
        public string comments { get; set; }
        public int UserAddress { get; set; }
        public int Price { get; set; }
        public string Phone { get; set; }

    }
}
