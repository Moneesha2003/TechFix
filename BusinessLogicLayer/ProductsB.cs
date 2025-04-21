using System;
using System.Data;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class ProductsB
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }

        public int insert()
        {
            string sql = "INSERT INTO tblInventory_B (ProductID, ProductName, ProductPrice, Quantity) VALUES (@ProductID, @ProductName, @ProductPrice, @Quantity)";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@ProductName", ProductName),
                new SqlParameter("@ProductPrice", ProductPrice),
                new SqlParameter("@Quantity", Quantity)
            };
            return new DatabaseOperations().executeQuery(sql, parameters);
        }

        public int update()
        {
            string sql = "UPDATE tblInventory_B SET ProductName=@ProductName, ProductPrice=@ProductPrice, Quantity=@Quantity WHERE ProductID=@ProductID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@ProductName", ProductName),
                new SqlParameter("@ProductPrice", ProductPrice),
                new SqlParameter("@Quantity", Quantity)
            };
            return new DatabaseOperations().executeQuery(sql, parameters);
        }

        public int delete()
        {
            string sql = "DELETE FROM tblInventory_B WHERE ProductID=@ProductID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", ProductID)
            };
            return new DatabaseOperations().executeQuery(sql, parameters);
        }

        public DataSet find()
        {
            string sql = "SELECT * FROM tblInventory_B WHERE ProductID=@ProductID";
            SqlParameter[] parameters = {
                new SqlParameter("@ProductID", ProductID)
            };
            return new DatabaseOperations().selectQuery(sql, parameters);
        }

        public DataSet viewAll()
        {
            string sql = "SELECT * FROM tblInventory_B";
            return new DatabaseOperations().selectQuery(sql);
        }
    }
}
