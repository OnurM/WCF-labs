using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF.BMI
{
    /// <summary>
    /// Summary description for CalculateBMIService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculateBMIService : System.Web.Services.WebService
    {

        [WebMethod]
        public double CalculateMyBMI(double heightInMeters, double weight)
        {
            return weight/(heightInMeters*heightInMeters);
        }
    }
}
