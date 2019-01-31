using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class4
{
    public partial class TextButtonControl : System.Web.UI.UserControl
    {
        public string PageTitle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PageTitle = TextBox1.Text;
        }
    }
}