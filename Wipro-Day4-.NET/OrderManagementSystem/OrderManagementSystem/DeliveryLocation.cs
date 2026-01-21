using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{

    
        // Struct is lightweight and fast
        public struct DeliveryLocation
        {
            public double Latitude;
            public double Longitude;

            public DeliveryLocation(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
        }
    }

