using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManolisShop.ManolisModels
{
    internal class RegisterModel
    {
        public Register Details { get; set; }
        public bool IsRegister { get; set; }
        public string Error { get; set; }
        public bool HasAcceptPrivacyandPolicy { get; set; }

    }
}
