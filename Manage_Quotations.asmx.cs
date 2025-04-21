using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogicLayer;

namespace TechFix
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    
    public class Manage_Quotations : System.Web.Services.WebService
    {
        ManageQuotations manageQuotations = new ManageQuotations();

        [WebMethod]
        public string ApproveQuotation(int quotationId, string supplier, string productName, int requiredQuantity, decimal totalPrice)
        {
            try
            {
                manageQuotations.ApproveQuotation(quotationId, supplier, productName, requiredQuantity, totalPrice);
                return "Quotation Approved Successfully!";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        [WebMethod]
        public string RejectQuotation(int quotationId)
        {
            try
            {
                manageQuotations.RejectQuotation(quotationId);
                return "Quotation Rejected Successfully!";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
