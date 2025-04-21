using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;

namespace TechFix
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text.Trim();
            string password = txtPassword.Text.Trim();

            UserService userService = new UserService();
            string role = userService.Login(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                switch (role)
                {
                    case "Manager":
                        Response.Redirect("ManagementDashboard.aspx");
                        break;
                    case "Accountant":
                        Response.Redirect("AccountantDashboard.aspx");
                        break;
                    case "Supplier A":
                        Response.Redirect("SupplierA.aspx");
                        break;
                    case "Supplier B":
                        Response.Redirect("SupplierB.aspx");
                        break;
                    default:
                        lblMessage.Text = "Login failed";
                        break;
                }
            }
            else
            {
                lblMessage.Text = "Login failed";
            }
        }
    }
}