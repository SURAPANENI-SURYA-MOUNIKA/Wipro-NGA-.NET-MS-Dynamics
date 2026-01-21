// See https://aka.ms/new-console-template for more information
using System;
using OrderManagementSystem;

namespace OrderManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create delivery location
            DeliveryLocation location = new DeliveryLocation(17.3850, 78.4867);

            // Choose payment method
            IPaymentMethod payment = new CreditCardPayment();

            // Create order
            Order order = new Order
            {
                OrderId = 101,
                Status = OrderStatus.Confirmed,
                Location = location,
                PaymentMethod = payment
            };

            // Display order details
            Console.WriteLine("Order ID: " + order.OrderId);
            Console.WriteLine("Order Status: " + order.Status);
            Console.WriteLine("Delivery Location: " +
                order.Location.Latitude + ", " +
                order.Location.Longitude);

            // Process payment
            order.ProcessPayment();

            Console.ReadLine();
        }
    }
}

