﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        logoMagmattec.Attributes.Add("onmouseover", "this.style.opacity= 0.5");

        logoMagmattec.Attributes.Add("onmouseout", "this.style.opacity= 1");
    }
}