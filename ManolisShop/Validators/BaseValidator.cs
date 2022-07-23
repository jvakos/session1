using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.Validators
{
    internal abstract class BaseValidator
    {
        public abstract string? Error { get; set; }

        public abstract bool Validate();
    }
}
