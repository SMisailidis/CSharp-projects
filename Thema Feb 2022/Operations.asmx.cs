using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Thema_Feb_2022
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
        public String operation(String s1, String s2, String s3)
        {
            if (!s1.Contains(s2))
            {
                return "Error: " + s1 + " doesn't containt the word: " + s2;
            }

            String result = s1.Replace(s2, s3);

            return result;
        }
    }
}
