using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFix
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        localhost.InventoryA_ManagementSystem ims = new localhost.InventoryA_ManagementSystem();
        private string conString;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicePointManager.ServerCertificateValidationCallback += ValidateServerCertificate;
        }
        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                    string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtProductPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtProductQuantity.Text))
                {
                    lblMessage.Text = "All fields are required.";
                    return;
                }

                int id = Convert.ToInt32(txtProductID.Text);
                string name = txtProductName.Text;
                int price = Convert.ToInt32(txtProductPrice.Text);
                int quantity = Convert.ToInt32(txtProductQuantity.Text);

                if (ims.insertProducts(id, name, price, quantity) > 0)
                {
                    lblMessage.Text = "Product inserted successfully.";
                }
                else
                {
                    lblMessage.Text = "Error inserting product.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtProductID.Text);
                string name = txtProductName.Text;
                int price = Convert.ToInt32(txtProductPrice.Text);
                int quantity = Convert.ToInt32(txtProductQuantity.Text);

                if (ims.updateProducts(id, name, price, quantity) > 0)
                {
                    lblMessage.Text = "Product updated successfully.";
                }
                else
                {
                    lblMessage.Text = "Error updating product.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtProductID.Text);
                if (ims.deleteProducts(id) > 0)
                {
                    lblMessage.Text = "Product Record Deleted";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtProductID.Text);
                DataSet ds = ims.findProducts(id);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtProductName.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
                    txtProductPrice.Text = ds.Tables[0].Rows[0]["ProductPrice"].ToString();
                    txtProductQuantity.Text = ds.Tables[0].Rows[0]["Quantity"].ToString();
                }
                else
                {
                    lblMessage.Text = "Product not found";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;


            lblMessage.Text = string.Empty;
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = ims.findAll();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdAllProducts.DataSource = ds.Tables[0];
                    grdAllProducts.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        protected void btnQuotations_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            string connectionString = "Server=(localdb)\\Local;Database=TechFixDB;Trusted_Connection=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT QuotationID, ProductName, RequiredQuantity, TotalPrice FROM tblQuot_A";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grdQuotations.DataSource = dt;
                grdQuotations.DataBind();
            }
        }
    }
}