using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class4
{
    public partial class UserInfoBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfoBoxControl1.UserName = "Anna";
            UserInfoBoxControl1.UserAge = 22;
            UserInfoBoxControl1.UserCity = "Montreal";



        }
    }
}