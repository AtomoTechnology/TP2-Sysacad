using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class field : System.Web.UI.UserControl
    {
        public string Value
        {
            get
            {
                return txtBox.Text;

            }
            set {  txtBox.Text = value; }
        }
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}