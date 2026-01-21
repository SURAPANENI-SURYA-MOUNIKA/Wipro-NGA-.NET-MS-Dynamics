using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
   
        

        // Class represents a real-world order
        public class Order
        {
            public int OrderId { get; set; }
            public OrderStatus Status { get; set; }
            public DeliveryLocation Location { get; set; }
            public IPaymentMethod PaymentMethod { get; set; }

            public void ProcessPayment()
            {
                PaymentMethod.MakePayment();
            }
        }
    }
