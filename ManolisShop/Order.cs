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
        public address address { get; set; }
        public DateTime OrderTime { get; set; }
        public string comments { get; set; }
        public int UserAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public string Phone { get; set; }
        public string Tk { get; set; }
        public string Town { get; set; }
        public bool PaymentTypes { get; set; } //Μετρητά η κάρτα
        
        public bool receipt { get; set; } //Απόδειξη η τιμολόγιο
        public string deliveryfee { get; set; } //μεταφορικά

        public List<CartItem> OrderList { get; set; }  

    }
}
