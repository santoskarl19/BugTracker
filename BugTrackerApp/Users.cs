using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    internal class Users
    {
        BugTrackerDatabase entities;

        public Users()
        {
            entities = new BugTrackerDatabase();
        }

        public List<string> GetAllUsers()
        {
            List<string> userFirstNames = new List<string>();

            var users = entities.developers.ToList();

            foreach (var user in users)
            {
                userFirstNames.Add(user.FirstName);
            }

            return userFirstNames;
        }
    }
}
