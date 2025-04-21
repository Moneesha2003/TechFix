using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogicLayer
{
    public class Accountant
    {
        public string ProductName { get; set; }
        public int RequiredQuantity { get; set; }
        public double TotalPrice { get; set; }
        public string Supplier { get; set; }

        public int submit()
        {
            // Modify the query to check for uniqueness based on ProductName and Supplier.
            string checkSql = "SELECT COUNT(*) FROM tblQuatations WHERE ProductName = @ProductName AND Supplier = @Supplier";
            string insertSql = "INSERT INTO tblQuatations (ProductName, RequiredQuantity, TotalPrice, Supplier) VALUES (@ProductName, @RequiredQuantity, @TotalPrice, @Supplier)";
            string updateSql = "UPDATE tblQuatations SET RequiredQuantity = @RequiredQuantity, TotalPrice = @TotalPrice WHERE ProductName = @ProductName AND Supplier = @Supplier";

            try
            {
                SqlParameter[] checkParameters = {
            new SqlParameter("@ProductName", ProductName),
            new SqlParameter("@Supplier", Supplier)
        };

                int count = (int)new DatabaseOperations().executeScalar(checkSql, checkParameters);

                if (count > 0)
                {
                    // If the product already exists for the same supplier, update the record.
                    SqlParameter[] updateParameters = {
                new SqlParameter("@ProductName", ProductName),
                new SqlParameter("@RequiredQuantity", RequiredQuantity),
                new SqlParameter("@TotalPrice", TotalPrice),
                new SqlParameter("@Supplier", Supplier)
            };
                    return new DatabaseOperations().executeQuery(updateSql, updateParameters);
                }
                else
                {
                    // If the product does not exist for this supplier, insert a new record.
                    SqlParameter[] insertParameters = {
                new SqlParameter("@ProductName", ProductName),
                new SqlParameter("@RequiredQuantity", RequiredQuantity),
                new SqlParameter("@TotalPrice", TotalPrice),
                new SqlParameter("@Supplier", Supplier)
            };
                    return new DatabaseOperations().executeQuery(insertSql, insertParameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Submit failed: " + ex.Message);
            }
        }


    }

}
