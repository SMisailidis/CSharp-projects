using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thema_6B_Feb_2022
{
    public partial class Thema_6B_Feb_2022 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info MyWS = new eu.dataaccess.footballpool.ws.Info();

        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            eu.dataaccess.footballpool.ws.tTeamPlayerCardRankInfo[] temp = myWS.PlayersWithCardsRanked();
            foreach (eu.dataaccess.footballpool.ws.tTeamPlayerCardRankInfo i in temp)
            {
                if (i.iRedCards > 0)
                {
                    results[count] = i.sName;
                    count++;
                    if (count > 5) break;
                }
            }
        }
    }
}