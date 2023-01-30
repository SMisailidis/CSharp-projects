using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Thema_Feb_2021
{
    /// <summary>
    /// Summary description for Operations
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Operations : System.Web.Services.WebService
    {

        [WebMethod]
        public double thirdPower(double num)
        {
            double temp = Math.Pow(num, 3);

            double formattedNum = formatter(temp);

            return formattedNum;
        }

        [WebMethod]
        public double power(double num1, double num2)
        {
            double temp = Math.Pow(num1, num2);

            double formattedNum = formatter(temp);

            return formattedNum;
        }

        [WebMethod]
        private double formatter(double num)
        {
            String formatter = num.ToString("0.00");

            double formattedNum = Convert.ToDouble(formatter);

            return formattedNum;
        }
    }
}
