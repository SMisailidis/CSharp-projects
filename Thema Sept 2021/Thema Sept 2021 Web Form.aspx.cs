using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thema_Sept_2021
{
    public partial class Thema_Sept_2021_Web_Form : System.Web.UI.Page
    {
        Operation myOperation = new Operation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OperationButton_Click(object sender, EventArgs e)
        {
            String s1 = FirstWordTextBox.Text;
            String s2 = SecondWordTextBox.Text;
            int plithos = Convert.ToInt32(PlithosTextBox.Text);

            String result = myOperation.operation(s1, s2, plithos);

            ResultOfOperationLabel.Text = result;
        }
    }
}