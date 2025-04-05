using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayApp
{
    public class PaymentMethod
    {
        public string DisplayName { get; set; }
        public string ClassName { get; set; }  

        public PaymentMethod(string displayName, string className)
        {
            DisplayName = displayName;
            ClassName = className;
        }
    }
}
