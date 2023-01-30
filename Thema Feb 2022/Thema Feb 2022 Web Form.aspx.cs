using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thema_Feb_2022
{
    public partial class Thema_Feb_2022_Web_Form : System.Web.UI.Page
    {
        Operations myOperation = new Operations();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReplaceButton_Click(object sender, EventArgs e)
        {
            String s1 = MainWordTextBox.Text;
            String s2 = WordForReplaceTextBox.Text;
            String s3 = ReplacementWordTextBox.Text;

            String result = myOperation.operation(s1, s2, s3);

            InitialWordPlace.Text = s1;
            ResultWordLabel.Text = result;
        }
    }
}