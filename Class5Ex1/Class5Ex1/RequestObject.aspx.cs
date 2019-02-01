using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class5Ex1
{
    public partial class RequestObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            StringBuilder sbInfo = new StringBuilder();
            // Display some of the path related properties of the HttpRequest object
            sbInfo.Append("The Url of the ASPX page: " + Request.Url + "<br>");
            sbInfo.Append("The Virtual File Path: " + Request.FilePath + "<br>");
            sbInfo.Append("The Physical File Path: " + Request.PhysicalPath + "<br>");
            sbInfo.Append("The Application Path: " + Request.ApplicationPath + "<br>");
            sbInfo.Append("The Physical Application Path: " + Request.PhysicalApplicationPath + "<br>");
            // Display the request header
            sbInfo.Append("Request Header:");
            sbInfo.Append("<br>");
            NameValueCollection nvcHeaders = Request.Headers;
            String[] astrKeys = nvcHeaders.AllKeys;
            // Iterate through all header keys and display their values
            foreach (String strKey in astrKeys)
            {
                sbInfo.Append(strKey + ": " + nvcHeaders[strKey].ToString());
                sbInfo.Append("<br>");
            }
            // Call MapPath() method to find the physical path
            sbInfo.Append("The physical path of the current aspx file: ");
            sbInfo.Append(Request.MapPath("RequestObject.aspx"));
            Label1.Text = sbInfo.ToString();

            StringBuilder browserInfo = new StringBuilder();
            // Get the reference to the HttpBrowserCapabilities object 
            HttpBrowserCapabilities browser = Request.Browser;
            // Display the properties of the HttpBrowserCapabilities Class
            browserInfo.AppendFormat("<br>Browser : " + browser.Browser + "<br>");
            browserInfo.AppendFormat("Browser Version: " + browser.Version + "<br>");
            browserInfo.AppendFormat("Client's Platform: " + browser.Platform + "<br>");
            browserInfo.AppendFormat(".NET CLR Version: " + browser.ClrVersion + "<br>");
            browserInfo.AppendFormat("ECMA Script Version: " + browser.EcmaScriptVersion + "<br>");
            browserInfo.AppendFormat("JavaScript Support: " + browser.JavaScript + "<br>");
            browserInfo.AppendFormat("Microsoft HTML Document Object Model Version: " + browser.MSDomVersion + "<br>");
            browserInfo.AppendFormat("World Wide Web (W3C) XML Document " + " Object Model Version: " + browser.W3CDomVersion + "<br>");
            Label2.Text = browserInfo.ToString();

            //Add session info
            Session["TeacherName"] = "Dan";
        }
    }
}