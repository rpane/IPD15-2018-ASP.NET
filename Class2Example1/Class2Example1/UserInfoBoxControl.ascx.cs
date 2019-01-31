using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class2Example1
{
    public partial class UserInfoBoxControl : System.Web.UI.UserControl
    {
        //public string myInstanceVar;
        //public static string myStaticVar;

        public string UserName { get; set; }
        public string UserAge { get; set; }
        public string UserCountry { get; set; }


        //public int MyMethod()
        //{
        //    int myLocalVar = 10;
        //    return myLocalVar;
        //}
    }

    //public class MyTestClass
    //{

    //    UserInfoBoxControl uibc = new UserInfoBoxControl();
    //    public void MyTestMethod()
    //    {
    //        string myString = uibc.myInstanceVar;
    //        string myStaticString = UserInfoBoxControl.myStaticVar;
    //    }
        
    //}
}