using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    internal class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public List<Order>  Orders { get; set; } //Παραγγελείες που έχει κάνει.
        public List<Address> Address{ get; set; } //diaeyuynshs που έχει kataxrisei.

        //public address address { get; set; }




    }
}
