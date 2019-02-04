using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginExample
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                loginInfo.InnerHtml = "Log Off";
            }
            else
            {
                loginInfo.InnerHtml = "Log On";
            }
        }
        protected void about_click(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("About.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
           
        }

        protected void contact_click(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("Contact.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        protected void home_click(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void logOff_click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }

    }
}