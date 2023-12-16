﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(MaleRadio.Checked)
            { 
                Response.Write("Male Checked");
            }
            if (FemaleRadio.Checked)
            {
                Response.Write("FemaleRadio Checked");
            }
            if (UnknownRadio.Checked)
            {
                Response.Write("UnknownRadio Checked");
            }
        }

        protected void MaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("Male Checked");
        }
    }
}