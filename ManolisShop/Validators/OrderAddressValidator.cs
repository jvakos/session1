﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.Validators
{
    internal class OrderAddressValidator : BaseValidator
    {
        public override string? Error { get; set; }
        public Address address { get; set; } = new Address();

        public override bool Validate()
        {
            if (address.address.Length < 5)
            {
                Error = "Δεν εχετε συμπληρώσει διεύθυνση";
                return false;
            }
            if (address.Phone.Length < 5)
            {
                Error = "Δεν εχετε συμπληρώσει τηλεφωνο";
                return false;
            }

            if (address.TK.Length < 1)
            {
                Error = "Δεν εχετε συμπληρώσει ΤΚ";
                return false;
            }

            if (address.Ringbell.Length < 5)
            {
                Error = "Δεν εχετε συμπληρώσει κουδούνι";
                return false;
            }

            return true;

        }
    }
}
