using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayApp
{
    public class PaymentMethodManager
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentMethodManager(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public string RetrievePaymentDetails(decimal amount)
        {
            return _paymentMethod.GetPaymentDetails(amount);
        }
    }
}
