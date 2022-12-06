using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockPrediction
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var highestvalue = TextBox1.Text;
            int value = Convert.ToInt32(highestvalue);

            var number = value + ((23.6 / 100) * value);
            Label1.Text=("The 23.6 percentage of " + value + " is : " + number);
            var number1 = value + ((38.2 / 100) * value);
            Label2.Text=("The 38.2 percentage of " + value + " is : " + number1);
            var number3 = value + ((61.8 / 100) * value);
            Label3.Text=("The 61.8 percentage of " + value + " is : " + number3);

            Label5.Text = ("The 23.6 percentage of " + value + " is : " + number);
            Label6.Text = ("The 38.2 percentage of " + value + " is : " + number1);
            Label7.Text = ("The 61.8 percentage of " + value + " is : " + number3);







        }
    }
}