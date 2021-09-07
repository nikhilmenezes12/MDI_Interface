using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Interface.UserCtrl
{
    public partial class CtrlButtonLed : UserControl
    {

        public event EventHandler btnOnClick;


        public CtrlButtonLed()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (btnOnClick != null)
                btnOnClick(sender, e);
        }

        public string SetButtonName {
            set { button1.Text = value; }
        }

        public Color ChangeLblBackgroundColor {
            set { label1.BackColor = value;  }
        }
    }
}
