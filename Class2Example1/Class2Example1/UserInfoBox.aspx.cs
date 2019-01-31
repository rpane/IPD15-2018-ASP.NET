using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class2Example1
{
    public partial class UserInfoBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoBoxControl1.UserName = "Dan";
            UserInfoBoxControl1.UserAge = "18";
            UserInfoBoxControl1.UserCountry = "Canada";
        }
    }
}