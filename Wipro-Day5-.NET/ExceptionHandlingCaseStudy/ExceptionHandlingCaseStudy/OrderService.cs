using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandlingCaseStudy.CustomException;

namespace ExceptionHandlingCaseStudy
{
    public class OrderService
    {
        // method for placing an order
        public void PlaceOrder(int quantity, bool isPaymentServiceDown)
        {
            try
            {
                // 1. Validate input
                if (quantity <= 0)
                {
                    throw new ValidationException("Quantity must be greater than zero.");
                }

                // 2. Check business rules
                if (quantity > 100)
                {
                    throw new BusinessRuleException("Maximum allowed quantity per order is 100.");
                }

                // 3. Check external service (payment gateway simulation)
                if (isPaymentServiceDown)
                {
                    throw new ExternalServiceException("Payment gateway is currently unavailable. Please try again later.");
                }

                // If everything is fine
                Console.WriteLine($"SUCCESS: Order placed successfully! Quantity: {quantity}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                // Smart handling: decide what to log and what to show silently
                HandleException(ex);
            }
        }

        // This method decides whether to log or handle silently
        private void HandleException(Exception ex)
        {
            // Validation errors are expected → we don't log them
            if (ex is ValidationException)
            {
                Console.WriteLine("Validation Error (shown to user only, not logged):");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                return;
            }

            Logger.Log(ex);   

            // Showing the reason message to user
            if (ex is BusinessRuleException)
            {
                Console.WriteLine("Business Rule Violation:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please correct your order.");
            }
            else if (ex is ExternalServiceException)
            {
                Console.WriteLine("Service Issue:");
                Console.WriteLine(ex.Message);
            }
            else
            {
                Console.WriteLine("Unexpected error occurred.");
            }

            Console.WriteLine();
        }
    }
}
