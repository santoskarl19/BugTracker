using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    interface LoginFunctions
    {
        
        void AddUser(Employee employee);
        void UpdatePassword(string userName, Employee employee);
        Employee GetEmployee(string userName, string password);
    }

    internal class UserRepository : LoginFunctions
    {
        public UserRepository()
        {
            //entities = new BugTrackerUserDatabaseEntities();
        }
        public void AddUser(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(string userName, string password)
        {
            //return entities.Employees.Find(userName, password);
        }

        public void UpdatePassword(string userName, Employee employee)
        {
            throw new NotImplementedException();
            
        }
    }
}
