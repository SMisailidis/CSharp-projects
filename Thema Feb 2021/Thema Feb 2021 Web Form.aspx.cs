using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Thema_Feb_2021
{
    public partial class Thema_Feb_2021_Web_Form : System.Web.UI.Page
    {
        Operations myOperations = new Operations();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ThirdPowerButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(ThirdPowerTextBox0.Text);

            double result = myOperations.thirdPower(number);

            ResultOfFirstOperation.Text = result.ToString();
        }

        protected void powerOfTwoNumbersButton0_Click(object sender, EventArgs e)
        {
            
            double number1 = Convert.ToDouble(baseNumberTextBox0.Text);

            double number2 = Convert.ToDouble(exponentNumberTextBox0.Text);

            double result = myOperations.power(number1, number2);

            ResultOfSecondOperation.Text = result.ToString();
        }
    }
}