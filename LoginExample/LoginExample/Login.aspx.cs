using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginExample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == Global.username && TextBox2.Text == Global.password)
            {
                Session["Username"] = TextBox1.Text;
                Session["Password"] = TextBox2.Text;

                Response.Redirect("Default.aspx");
            }           
        }

      
    }
}