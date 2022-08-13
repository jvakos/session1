using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.ManolisModels
{
    internal class PaymentModel
    {
        public Order Details { get; set; }
        public double PaymentCard { get; set; }
        public int CardCcv { get; set; }
        public string CardExpiresDate { get; set; }
        public string CardName { get; set; }

    }
}
