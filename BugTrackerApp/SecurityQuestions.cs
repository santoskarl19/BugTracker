using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    // enum for security questions to be displayed in the combo box
    // during account registration
    
    internal class SecurityQuestion
    {
        public static List<string> Questions { get; } = new List<string>
        {
            "In what city were you born?",
            "What is the name of your favorite pet?",
            "What is your mother's maiden name?",
            "What is your favorite book?",
            "What is your favorite movie?",
            "What is the name of your first school?"
        };
    }
}
