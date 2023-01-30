using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Thema_Sept_2021
{
    /// <summary>
    /// Summary description for Operation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Operation : System.Web.Services.WebService
    {

        [WebMethod]
        public String operation(String s1, String s2, int plithos)
        {
            if(plithos > s1.Length)
            {
                return "Error, " + plithos + " is larger than the length of word 1: " + s1.Length; 
            }

            if(s2.Length - plithos < 0)
            {
                return "Error, " + plithos + " is larger than the length of word 2: " + s2.Length;
            }

            String temp1 = s1.Substring(0, plithos);
            String temp2 = s2.Substring(s2.Length - plithos);

            return temp1 + temp2;
        }
    }
}
