using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class2Example1
{
    public partial class TextButtonControl : System.Web.UI.UserControl
    {
        public string PageTitle { get; set; }


        protected void Button1_Click(object sender, EventArgs e)
        {
            this.PageTitle = this.TextBox1.Text;
        }
    }
}