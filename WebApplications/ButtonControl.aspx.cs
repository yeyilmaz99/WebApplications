using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class ButtonControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Buttons_Command(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "Print":
                    OutputLabel.Text = "You Clicked Print Button";
                    break;
                case "Delete":
                    OutputLabel.Text = "You Clicked Delete Button";
                    break;
                case "Show":
                    if(e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel.Text = "You Clicked Top10 Button";
                    }
                    else
                    {
                        OutputLabel.Text = "You Clicked Bottom10 Button";
                    }
                    break;
                default:
                    OutputLabel.Text = "We dont know witch button you clicked";
                    break;

            }

        }
    }
}