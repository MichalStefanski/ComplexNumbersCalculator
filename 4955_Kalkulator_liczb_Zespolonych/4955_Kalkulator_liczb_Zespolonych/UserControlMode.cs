using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4955_Kalkulator_liczb_Zespolonych
{
    public partial class UserControlMode : UserControl
    {
        public event EventHandler SwitchEvent;

        public string Nazwa
        {
            get { return groupBoxMode.Text; }
            set { groupBoxMode.Text = value; }
        }

        public string Switch1Name
        {
            get { return radioButtonMode1.Text; }
            set { radioButtonMode1.Text = value; }
        }

        public string Switch2Name
        {
            get { return radioButtonMode2.Text; }
            set { radioButtonMode2.Text = value; }
        }

        public bool IsOn1
        {
            get { return radioButtonMode1.Checked; }
            set { radioButtonMode1.Checked = value; }
        }

        public bool IsOn2
        {
            get { return radioButtonMode2.Checked; }
            set { radioButtonMode2.Checked = value; }
        }         

        public UserControlMode()
        {
            InitializeComponent();
        }

        private void radioButtonMode1_Click(object sender, EventArgs e)
        {
            if (SwitchEvent != null)
            {
                SwitchEvent(null, null);
            }
        }

        private void radioButtonMode2_Click(object sender, EventArgs e)
        {
            if (SwitchEvent != null)
            {
                SwitchEvent(null, null);
            }
        }
    }
}
