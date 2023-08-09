﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp
{
    
    interface LoginFunctions
    {

        void AddUser(developer employee);
        bool UpdatePasswordVerification(string userName, string secQuestion, string secAnswer);
        bool CheckLoginInfo(string userName, string password);
    }

    internal class UserRepository : LoginFunctions
    {
        UserDatabaseEntities1 entities;
        UserName userName;
        public UserRepository()
        {
            entities = new UserDatabaseEntities1();
        }

        // add user to database
        public void AddUser(developer employee)
        {
            entities.developers.Add(employee);
            entities.SaveChanges();

        }

        // check user's login information | verify username and password against database
        public bool CheckLoginInfo(string userName, string password)
        {
            string usernameToCheck = userName;
            string passwordToCheck = password;

            // find is user exist in database using username
            var userToFind = entities.developers.Find(userName);

            // if not found
            if (userToFind == null)
                return false;

            // if found, check its username and password against input
            if (userToFind.UserName == usernameToCheck && userToFind.Password == passwordToCheck)
                return true;

            return false;
        }

        // to reset passwrod | verify username, security question and security password
        public bool UpdatePasswordVerification(string userName, string secQuestion, string secAnswer)
        {
            string userNameToCheck = userName;
            string secQuestionToCheck = secQuestion;
            string secAnswerToCheck = secAnswer;

            // find if user exist in database using username
            var userToFind = entities.developers.Find(userName);

            // if user not found
            if (userToFind == null)
                return false;

            // if found, validate input fields
            if (userToFind.UserName == userNameToCheck &&
                userToFind.SecurityQuestion ==  secQuestionToCheck &&
                userToFind.SecurityAnswer == secAnswerToCheck)
            {


                return true;
            }


            return false;
        }

        public void UpdatePassword(developer employee, string password)
        {
            employee.Password = password;
            entities.SaveChanges();
        }
    }
}
