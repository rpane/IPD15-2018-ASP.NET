using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class8Example1.Views.HelloWorld
{
    public partial class Test : ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBox1.Text))
            {
                Label1.Text = TextBox1.Text;
            }
        }
    }
}