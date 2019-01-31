using System;
using System.Web.UI.WebControls;

namespace Class2Example1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            //HelloWorldLabel.Text = "From PageInit";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "From PageInitComplete";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "From PageLoad";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "From PagePreRender";
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "From PageRender";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "From PageUnload";
        }

        protected void GreetButton_Click(object sender, EventArgs e)
        {
            //Copy the text from TextBox into the Label
            if(String.IsNullOrEmpty(this.TextInput.Text))
            {
                this.HelloWorldLabel.Text = "Hello, from default value!";
            }
            else
            {
                this.HelloWorldLabel.Text = this.TextInput.Text;
            }

        }

        protected void GreetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Copy the value of the selected item into the Label
            //this.HelloWorldLabel.Text = "Hello from " + this.GreetList.SelectedValue;
            this.HelloWorldLabel.Text = String.Format("Hello from {0}", this.GreetList.SelectedValue);
        }
    }
}