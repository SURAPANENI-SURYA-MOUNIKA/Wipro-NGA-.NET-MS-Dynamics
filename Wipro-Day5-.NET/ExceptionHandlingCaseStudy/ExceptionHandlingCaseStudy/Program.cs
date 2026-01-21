// See https://aka.ms/new-console-template for more information
using ExceptionHandlingCaseStudy;
using System;

namespace ExceptionHandlingCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            //Console.WriteLine("=== Test Cases \n");

            // Test 1: Invalid input (should NOT be logged)
            Console.WriteLine("Test 1: Quantity = 0");
            orderService.PlaceOrder(0, false);

            // Test 2: Business rule violation (should be logged)
            Console.WriteLine("Test 2: Quantity = 150");
            orderService.PlaceOrder(150, false);

            // Test 3: External service down (should be logged)
            Console.WriteLine("Test 3: Payment service down");
            orderService.PlaceOrder(50, true);

            // Test 4: Successful order
            Console.WriteLine("Test 4: Normal order");
            orderService.PlaceOrder(45, false);

           
        }
    }
}
