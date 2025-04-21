using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        quatations.Quatations q = new quatations.Quatations();
        private string conString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridA();
                BindGridB();
            }
        }

        private void BindGridA()
        {
            string connectionString = "Server=(localdb)\\Local;Database=TechFixDB;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, ProductPrice, Quantity FROM tblInventory_A";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        private void BindGridB()
        {
            string connectionString = "Server=(localdb)\\Local;Database=TechFixDB;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, ProductPrice, Quantity FROM tblInventory_B";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Calculate")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];

                TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");
                Label lblTotalPrice = (Label)row.FindControl("lblTotalPrice");

                if (txtQuantity != null && lblTotalPrice != null)
                {
                    double productPrice = Convert.ToDouble(GridView1.DataKeys[rowIndex].Values["ProductPrice"]); 
                    int quantity;
                    if (int.TryParse(txtQuantity.Text, out quantity))
                    {
                        double totalPrice = productPrice * quantity;
                        lblTotalPrice.Text = totalPrice.ToString("F2");
                    }
                    else
                    {
                        lblTotalPrice.Text = "Invalid Quantity";
                    }
                }
            }
            if (e.CommandName == "Submit")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];

                
                string productName = row.Cells[1].Text; 
                int quantity = int.Parse(((TextBox)row.FindControl("txtQuantity")).Text);
                double productPrice = Convert.ToDouble(GridView1.DataKeys[rowIndex].Values["ProductPrice"]);
                double totalPrice = productPrice * quantity;

                Quatations q = new Quatations();
                
                q.submitQuatations(productName, quantity, totalPrice, "Supplier A");

                q.IncrementRequestCount();
            }

        }


        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Calculate")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView2.Rows[rowIndex];

                TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");
                Label lblTotalPrice = (Label)row.FindControl("lblTotalPrice");

                if (txtQuantity != null && lblTotalPrice != null)
                {
                    double productPrice = Convert.ToDouble(GridView2.DataKeys[rowIndex].Values["ProductPrice"]); 
                    int quantity;
                    if (int.TryParse(txtQuantity.Text, out quantity))
                    {
                        double totalPrice = productPrice * quantity;
                        lblTotalPrice.Text = totalPrice.ToString("F2");
                    }
                    else
                    {
                        lblTotalPrice.Text = "Invalid Quantity";
                    }
                }
            }
            if (e.CommandName == "Submit")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView2.Rows[rowIndex];

                string productName = row.Cells[1].Text; 
                int quantity = int.Parse(((TextBox)row.FindControl("txtQuantity")).Text);
                double productPrice = Convert.ToDouble(GridView2.DataKeys[rowIndex].Values["ProductPrice"]);
                double totalPrice = productPrice * quantity;

                Quatations q = new Quatations();
                
                q.submitQuatations(productName, quantity, totalPrice, "Supplier B");

                q.IncrementRequestCount();
            }

        }

        private class ProductRequest
        {
            private string productId;
            private string productName;
            private int quantity;
            private double totalPrice;

            public ProductRequest(string productId, string productName, int quantity, double totalPrice)
            {
                this.productId = productId;
                this.productName = productName;
                this.quantity = quantity;
                this.totalPrice = totalPrice;
            }
        }
    }
}