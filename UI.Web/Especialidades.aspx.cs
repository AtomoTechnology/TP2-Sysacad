﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Web.Helpers;

namespace UI.Web
{
    public partial class Especialidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Methods.ValidatePermission("Especialidades");            

        }

     
    }
}