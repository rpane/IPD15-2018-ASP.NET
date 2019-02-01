using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class5Ex1
{
    public partial class web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // Append a Header to the response to force a Download of Summary.txt as an attachment
            Response.AppendHeader("Content-Disposition", "Attachment;FileName=" + "Summary.txt");
            // Set the Content type to text/plain as the download file is a TXT file
            Response.ContentType = "text/plain";
            // Write the file to the Response
            Response.WriteFile("Summary.txt");
            // Stop further execution of the page
            Response.End();

        }
    }
}