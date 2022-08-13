using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.Validators
{
    internal class RegisterValidator : BaseValidator
    {
        public override string? Error { get; set; }
        public Register Regisvalidator { get; set; } = new Register();
        public override bool Validate()
        {
            if (Regisvalidator.Email.Length < 1)
            {
                Error = "Δεν έχετε σημπληρώσει Email";
                return false;
            }
            if (Regisvalidator.Password.Length < 3)
            {
                Error = "Αδύναμος κωδικός";
                return false;
            }
            if (Regisvalidator.ConfirmPassword != Regisvalidator.Password)
            {
                Error = "Λάθος κωδικός επιβεβαίωσης";
                return false;
            }
            if (Regisvalidator.Phone.Length < 10)
            {
                Error = "Λαθος τηλέφωνο, τα ψηφία πρέπει να είναι τουλάχιστον 10";
                return false;
            }
            if (Regisvalidator.Firstname.Length < 1)
            {
                Error = "Δεν έχετε συμπληρώση το όνομα σας";
                return false;
            }
            if (Regisvalidator.Lastname.Length < 1)
            {
                Error = "Δεν έχετε συμπληρώση επίθετο";
                return false;
            }

            return true;
        }
    }
}
