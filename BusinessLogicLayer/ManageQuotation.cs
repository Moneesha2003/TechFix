using System;
using System.Data;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class ManageQuotations
    {
        string connectionString = "Server=(localdb)\\Local;Database=TechFixDB;Trusted_Connection=True";

        public void ApproveQuotation(int quotationId, string supplier, string productName, int quantity, decimal totalPrice)
        {
            string tableName = supplier == "Supplier A" ? "tblQuot_A" : supplier == "Supplier B" ? "tblQuot_B" : null;
            string inventoryTable = supplier == "Supplier A" ? "tblInventory_A" : supplier == "Supplier B" ? "tblInventory_B" : null;

            if (tableName == null || inventoryTable == null)
            {
                throw new Exception("Invalid supplier");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Insert the approved quotation into the respective supplier's quotations table
                string insertQuery = $"INSERT INTO {tableName} (ProductName, RequiredQuantity, TotalPrice) VALUES (@ProductName, @Quantity, @TotalPrice)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@ProductName", productName);
                insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                insertCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                insertCmd.ExecuteNonQuery();

                // Delete the approved quotation from the general quotations table
                string deleteQuery = "DELETE FROM tblQuatations WHERE QuotationID = @QuotationID";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@QuotationID", quotationId);
                deleteCmd.ExecuteNonQuery();

                // Update the inventory table by reducing the quantity of the approved product
                string updateInventoryQuery = $"UPDATE {inventoryTable} SET Quantity = Quantity - @Quantity WHERE ProductName = @ProductName";
                SqlCommand updateCmd = new SqlCommand(updateInventoryQuery, conn);
                updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                updateCmd.Parameters.AddWithValue("@ProductName", productName);
                int rowsAffected = updateCmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected == 0)
                {
                    throw new Exception("Failed to update the inventory. Product not found.");
                }
            }
        }

        public void RejectQuotation(int quotationId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string deleteQuery = "DELETE FROM tblQuatations WHERE QuotationID = @QuotationID";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@QuotationID", quotationId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
