using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.ManolisModels
{
    internal class OrderValidator : BaseValidator
    {
        public List<BaseValidator> Validators { get; set; }
        public override string? Error { get; set; }

        public OrderValidator()
        {

            //Check adress
            //check payment
            //check user
            Validators = new List<BaseValidator>();
            Validators.Add(new OrderAddressValidator());
            Validators.Add(new OrderAddressValidator()); //payment validator
        }
        


        public override bool Validate()
        {
            foreach (var validator in Validators)
            {
                if (!validator.Validate())
                {
                    Error=validator.Error;                    
                }
            }


            return true; //false;
        }

        

    }
}
