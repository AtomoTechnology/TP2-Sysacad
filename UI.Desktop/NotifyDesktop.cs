using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class NotifyDesktop : Form
    {
        public NotifyDesktop(string msg)
        {
            InitializeComponent();
            this.lblMessage.Text = msg;
        }
        public static void GetNotify( string msg )
        {

            NotifyDesktop not = new NotifyDesktop( msg );
            not.ShowDialog();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
