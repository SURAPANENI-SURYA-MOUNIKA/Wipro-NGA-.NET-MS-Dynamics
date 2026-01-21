using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
   
        // Concrete implementation
        public class CreditCardPayment : IPaymentMethod
        {
            public void MakePayment()
            {
                Console.WriteLine("Payment processed using Credit Card.");
            }
        }
    }



