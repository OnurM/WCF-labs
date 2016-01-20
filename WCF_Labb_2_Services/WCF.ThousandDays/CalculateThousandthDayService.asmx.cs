using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCF.ThousandDays
{
    /// <summary>
    /// Summary description for CalculateThousandthDayService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculateThousandthDayService : System.Web.Services.WebService
    {

        [WebMethod]
        public DateTime CalculateThousandthDayOfLife(DateTime dateOfBirth)
        {
            var daysOld = DateTime.Now.Subtract(dateOfBirth).Days;
            var differenceModuloThousand = daysOld % 1000;
            var actualDaysLeft = 1000 - differenceModuloThousand;

            return DateTime.Now.AddDays(actualDaysLeft);
        }
    }
}
