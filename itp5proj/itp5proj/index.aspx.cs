﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itp5proj
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Item_Click(object sender, EventArgs e)
        {
            ifr.Src = Menu.SelectedValue + ".aspx";
        }
    }
}