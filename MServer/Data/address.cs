using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    public class address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }

        public int UserId { get; set; }

        public string Address { get; set; } = "";
        public string Ringbell { get; set; } = "";
        public string TK { get; set; } = "";
        public string Town { get; set; } = "";
        public string Comments { get; set; } = "";
        public string Phone { get; set; } = "";

    }
}
