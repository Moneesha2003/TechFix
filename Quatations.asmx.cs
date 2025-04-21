using System;
using System.Data;
using System.Web.Services;
using BusinessLogicLayer;

namespace TechFix
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class Quatations : System.Web.Services.WebService
    {
        [WebMethod]
        public int submitQuatations(string name, int quantity, double price, string supplier)
        {
            Accountant accountant = new Accountant
            {
                ProductName = name,
                RequiredQuantity = quantity,
                TotalPrice = price,
                Supplier = supplier
            };

            return accountant.submit(); 
        }


        public int GetRequestCount()
        {
            return Convert.ToInt32(System.Web.HttpContext.Current.Session["RequestCount"] ?? "0");
        }

        public void IncrementRequestCount()
        {
            int requestCount = Convert.ToInt32(System.Web.HttpContext.Current.Session["RequestCount"] ?? "0");
            requestCount++;
            System.Web.HttpContext.Current.Session["RequestCount"] = requestCount;
        }
    }
}

