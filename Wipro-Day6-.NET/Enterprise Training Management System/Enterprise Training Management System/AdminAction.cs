using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Training_Management_System
{

    class AdminAction                     // Stores admin action for undo
    {
        public string ActionDescription;  // Description of action

        public AdminAction(string action) // Constructor
        {
            ActionDescription = action;   // Save action description
        }
    }

}
