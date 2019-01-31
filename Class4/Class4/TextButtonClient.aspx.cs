using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class4
{
    public partial class TextButtonClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Title = TextButtonControl.PageTitle;
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Title = TextButtonControl.PageTitle;
        }

    }
}