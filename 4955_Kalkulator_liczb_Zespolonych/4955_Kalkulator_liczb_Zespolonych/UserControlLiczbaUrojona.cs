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
    public delegate void Notifier (UserControlLiczbaUrojona sender);
    public partial class UserControlLiczbaUrojona : UserControl
    {
        public event Notifier ValueChanged;

        private decimal _Re;
        private decimal _Im;

        public decimal Re
        {
            set { numericUpDownRe.Value = value; _Re = value; if (ValueChanged != null) ValueChanged(this); }
            get { return numericUpDownRe.Value; }
        }
        public decimal Im
        {
            set { numericUpDownIm.Value = value; _Im = value; }
            get { return numericUpDownIm.Value; }
        }

        public string Tekst
        {
            set { groupBox1.Text = value; }
            get { return groupBox1.Text; }
        }

        public UserControlLiczbaUrojona()
        {
            InitializeComponent();
        }
    }
}
