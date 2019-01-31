using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void greetButton_Click(object sender, EventArgs e)
        {
            string msg = textBox.Text;
            if (msg.Length == 0)
            {
                helloWorldLabel.Text = "Hello world!";
            }
            else
                helloWorldLabel.Text = msg;
        }

        protected void greetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            helloWorldLabel.Text = greetList.SelectedItem.Text;
        }
    }
}