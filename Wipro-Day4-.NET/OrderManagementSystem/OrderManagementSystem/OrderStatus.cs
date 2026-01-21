using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    
    
        // Enum prevents invalid order status values
        public enum OrderStatus
        {
            Pending,
            Confirmed,
            Shipped,
            Delivered,
            Cancelled
        }
    }

