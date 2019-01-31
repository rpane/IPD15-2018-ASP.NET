using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class2Example1
{
    public partial class UserInfoBoxDynamic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.PlaceHolder1.Controls.Add(LoadControl("~/UserInfoBoxControl.ascx"));

            UserInfoBoxControl myInfoBoxControl;
            for (int i=0; i<4; i++)
            {
                myInfoBoxControl = (UserInfoBoxControl)LoadControl("~/UserInfoBoxControl.ascx");

                myInfoBoxControl.UserName = "Danny" + i;
                myInfoBoxControl.UserAge = "2" + i ;
                myInfoBoxControl.UserCountry = "Canada" + i;

                this.PlaceHolder1.Controls.Add(myInfoBoxControl);
            }
            
        }
    }
}