using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop
{
    public class User : IdentityUser<int>
    {
       
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Order>  Orders { get; set; } //Παραγγελείες που έχει κάνει.




    }
}
