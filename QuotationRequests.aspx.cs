using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace TechFix
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ManageQuotations manageQuotations = new ManageQuotations();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string connectionString = "Server=(localdb)\\Local;Database=TechFixDB;Trusted_Connection=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT QuotationID, ProductName, Supplier, RequiredQuantity, TotalPrice FROM tblQuatations";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grdRequests.DataSource = dt;
                grdRequests.DataBind();
            }
        }
        protected void grdRequests_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Approve")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = grdRequests.Rows[index];

                int quotationId = Convert.ToInt32(row.Cells[0].Text);
                string productName = row.Cells[1].Text;
                string supplier = row.Cells[2].Text;
                int requiredQuantity = Convert.ToInt32(row.Cells[3].Text);
                decimal totalPrice = Convert.ToDecimal(row.Cells[4].Text);

                manageQuotations.ApproveQuotation(quotationId, supplier, productName, requiredQuantity, totalPrice);

                lblMessage.Text = "Quotation Approved Successfully!!";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                BindGrid();

            }
            else if (e.CommandName == "Reject")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = grdRequests.Rows[index];

                int quotationId = Convert.ToInt32(row.Cells[0].Text);

                manageQuotations.RejectQuotation(quotationId);

                lblMessage.Text = "Quotation Rejected Successfully!!";
                lblMessage.ForeColor = System.Drawing.Color.Red;

                BindGrid();

            }
        }
    }
}