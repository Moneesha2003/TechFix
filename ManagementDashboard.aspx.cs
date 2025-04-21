using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateRequestCount();
            }
        }
        private void UpdateRequestCount()
        {
            Quatations q = new Quatations();
            int requestCount = q.GetRequestCount();
            lblRequestCount.Text = requestCount.ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["RequestCount"] = 0;
            lblRequestCount.Text = "0";
            lblRequestCount.Visible = false;
            Response.Redirect("QuotationRequests.aspx");
        }
    }
}