using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform
{
    
    
     
    
        // This class holds platform-wide shared data
        public static class PlatformConfig
        {
            // Static property: common platform name
            public static string PlatformName { get; set; } = "LearnSmart";

            // Static property: maximum login attempts allowed
            public static int MaxLoginAttempts { get; set; } = 3;

            // Static property: total registered users
            public static int TotalUsers { get; private set; } = 0;

            // Static method to increment user count
            public static void IncrementUser()
            {
                TotalUsers++;
            }
        }
    }

