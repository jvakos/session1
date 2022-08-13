using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    internal class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public Address? Address { get; set; }
        public DateTime OrderTime { get; set; }
        public string? Comments { get; set; }
        public decimal TotalPrice { get; set; }
        //public int UserAddress { get; set; }
        //public string Phone { get; set; }
        //public string Tk { get; set; }
        //public string Town { get; set; }
        public PaymentType PaymentType { get; set; } //Μετρητά η κάρτα
        
        public bool Receipt { get; set; } //Απόδειξη η τιμολόγιο
        public decimal Deliveryfee { get; set; } //μεταφορικά

        public List<CartItem>? OrderList { get; set; }

        public User? User { get; set; }


    }

    enum PaymentType
    {
        Card,
        Cash,
        Point
    }
}
