using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class ApplicationObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class Global : System.Web.HttpApplication
        {
            public static readonly string TestString = "Testerizer";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Global.TestString;
        }
    }
}