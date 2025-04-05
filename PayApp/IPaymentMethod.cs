using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayApp
{
    public interface IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount);
    }
}
