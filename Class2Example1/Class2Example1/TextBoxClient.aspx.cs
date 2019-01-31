using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class2Example1
{
    public partial class TextBoxClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "From PageLoad";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.TextButtonControl1.PageTitle))
                this.Title = this.TextButtonControl1.PageTitle;
        }

    }
}