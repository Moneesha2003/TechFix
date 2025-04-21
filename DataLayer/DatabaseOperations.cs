using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DatabaseOperations
    {
        static string conString = "Server=(localdb)\\Local;Database=TechFixDB;Trusted_Connection=True";
        SqlConnection con = new SqlConnection(conString);

        public int executeQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                if (parameters != null)
                {
                    com.Parameters.AddRange(parameters);
                }
                con.Open();
                return com.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet selectQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                if (parameters != null)
                {
                    da.SelectCommand.Parameters.AddRange(parameters);
                }
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public string GetUserRole(string username, string password)
        {
            string role = null;
            string sql = "SELECT uRole FROM tblUsers WHERE uName = @username AND uPassword = @password";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            return role;
        }

        public static DataTable GetInventoryData(string inventoryType)
        {
            string tableName = inventoryType == "A" ? "tblInventory_A" : "tblInventory_B";
            string query = $"SELECT ProductID, ProductName, ProductPrice, Quantity FROM {tableName}";
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void UpdateInventoryData(string inventoryType, int productId, double quantity)
        {
            string tableName = inventoryType == "A" ? "tblInventory_A" : "tblInventory_B";
            string query = $"UPDATE {tableName} SET RequiredQuantity = @Quantity WHERE ProductID = @ProductID";
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public object executeScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

    }
}
