using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogicLayer
{
    public class UserAuthenticationLogic
    {
        public string GetUserRole(string username, string password)
        {
            DatabaseOperations dbOps = new DatabaseOperations();
            return dbOps.GetUserRole(username, password);
        }
    }
}
