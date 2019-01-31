using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class4
{
    public partial class UserInfoBoxDinamic : System.Web.UI.Page
    {
        UserInfoBoxControl myInfoBoxControl;
        protected void Page_Load(object sender, EventArgs e)
        {

            //this.PlaceHolder1.Controls.Add(LoadControl("~/UserInfoBoxControl.ascx"));
            

            
            for(int i = 0; i < 6; i++)
            {
                myInfoBoxControl= (UserInfoBoxControl)LoadControl("~/UserInfoBoxControl.ascx");
                myInfoBoxControl.UserName = "Jerry"+i;
                myInfoBoxControl.UserAge = 10+i;
                myInfoBoxControl.UserCity = "Montreal"+i;
                this.PlaceHolder1.Controls.Add(myInfoBoxControl);

            }
            
           



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            myInfoBoxControl = (UserInfoBoxControl)LoadControl("~/UserInfoBoxControl.ascx");
            string name = tbName.Text;
            int age = int.Parse(tbAge.Text);
            string city = tbCity.Text;
            myInfoBoxControl.UserName = name;
            myInfoBoxControl.UserAge = age;
            myInfoBoxControl.UserCity = city;
            this.PlaceHolder1.Controls.Add(myInfoBoxControl);



        }
    }
}