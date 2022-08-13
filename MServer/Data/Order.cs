using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public address address { get; set; }
        public DateTime OrderTime { get; set; }
        public string comments { get; set; }
        public decimal TotalPrice { get; set; }
        //public int UserAddress { get; set; }
        //public string Phone { get; set; }
        //public string Tk { get; set; }
        //public string Town { get; set; }
        public PaymentType PaymentType { get; set; } //Μετρητά η κάρτα
        
        public bool receipt { get; set; } //Απόδειξη η τιμολόγιο
        public decimal deliveryfee { get; set; } //μεταφορικά

        public List<CartItem> OrderList { get; set; }

        public User User { get; set; }


    }

    public enum PaymentType
    {
        Card,
        Cash,
        Point
    }
}
