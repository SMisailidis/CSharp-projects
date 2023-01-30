using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thema_6B_Feb_2022
{
    public partial class Thema_6B_2022_Feb_Web_Form : System.Web.UI.Page
    {

        eu.dataaccess.footballpool.ws.Info myWS = new eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] results = new string[6];
            int count = 0;
            eu.dataaccess.footballpool.ws.tTeamPlayerCardRankInfo[] temp = myWS.PlayersWithCardsRanked();
            foreach (eu.dataaccess.footballpool.ws.tTeamPlayerCardRankInfo i in temp)
            {
                if (i.iRedCards > 0)
                {
                    results[count] = i.sName;
                    count++;
                }
            }

            eu.dataaccess.footballpool.ws.tPlayerName[] temp1 = myWS.AllPlayerNames(true);
           
            count = 0;
            string result1 = "";

            foreach(eu.dataaccess.footballpool.ws.tPlayerName i in temp1)
            {

                if (i.sName.Equals(results[count]))
                {
                    results[count] = results[count] + " | " + i.sCountryName;
                    result1 += count+1 + ") " + results[count]+ "<br>";
                    count++;
                }
            }

            resultsBox.Text = result1;
        }
    }
}