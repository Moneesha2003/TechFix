using System;
using System.Data;
using System.Web.Services;
using BusinessLogicLayer;

namespace TechFix
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class InventoryA_ManagementSystem : System.Web.Services.WebService
    {
        [WebMethod]
        public int insertProducts(int id, string name, int price, int quantity)
        {
            try
            {
                ProductsA product = new ProductsA
                {
                    ProductID = id,
                    ProductName = name,
                    ProductPrice = price,
                    Quantity = quantity
                };
                return product.insert(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Insert failed: " + ex.Message);
            }
        }

        [WebMethod]
        public int updateProducts(int id, string name, int price, int quantity)
        {
            try
            {
                ProductsA product = new ProductsA
                {
                    ProductID = id,
                    ProductName = name,
                    ProductPrice = price,
                    Quantity = quantity
                };
                return product.update(); 
            }
            catch (Exception ex)
            {
                throw new Exception("Update failed: " + ex.Message);
            }
        }


        [WebMethod]
        public int deleteProducts(int id)
        {
            try
            {
                ProductsA product = new ProductsA
                {
                    ProductID = id
                };
                return product.delete();
            }
            catch (Exception ex)
            {
                throw new Exception("Delete failed: " + ex.Message);
            }
        }

        [WebMethod]
        public DataSet findProducts(int id)
        {
            try
            {
                ProductsA product = new ProductsA
                {
                    ProductID = id
                };
                return product.find();
            }
            catch (Exception ex)
            {
                throw new Exception("Find failed: " + ex.Message);
            }
        }

        [WebMethod]
        public DataSet findAll()
        {
            try
            {
                return new ProductsA().viewAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Find all failed: " + ex.Message);
            }
        }
    }
}
