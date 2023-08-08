using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    
    interface LoginFunctions
    {

        void AddUser(Developer employee);
        void UpdatePassword(string userName, Developer employee);
        Developer GetEmployee(string userName, string password);
    }

    internal class UserRepository : LoginFunctions
    {
        devsEntities entities;
        public UserRepository()
        {
            entities = new devsEntities();
        }
        public void AddUser(Developer employee)
        {
            entities.Developers.Add(employee);
            entities.SaveChanges();
        }

        public Developer GetEmployee(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(string userName, Developer employee)
        {
            throw new NotImplementedException();
        }
    }
}
