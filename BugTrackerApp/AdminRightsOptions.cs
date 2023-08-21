using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    internal class AdminRightsOptions
    {
        public static List<string> Options { get; } = new List<string>
        {
            "Yes",
            "No",
        };
    }
}
