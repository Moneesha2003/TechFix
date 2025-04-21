using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogicLayer;

namespace TechFix
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class UserService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Login(string username, string password)
        {
            UserAuthenticationLogic userAuthLogic = new UserAuthenticationLogic();
            return userAuthLogic.GetUserRole(username, password);
        }
    }
}
