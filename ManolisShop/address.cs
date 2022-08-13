using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    internal class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }

        public int UserId { get; set; }

        public string address { get; set; } = "";
        public string Ringbell { get; set; } = "";
        public string TK { get; set; } = "";
        public string Town { get; set; } = "";
        public string Comments { get; set; } = "";
        public string Phone { get; set; } = "";
        public User User { get; set; }
        
        //public List<Order> Orders { get; set; }

    }
}
