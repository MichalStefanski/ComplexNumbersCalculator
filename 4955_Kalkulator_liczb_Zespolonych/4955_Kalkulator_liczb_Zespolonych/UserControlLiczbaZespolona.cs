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
    public partial class UserControlLiczbaZespolona : UserControl
    {
        public decimal Re
        {
            get { return numericUpDownRe.Value; }
            set { numericUpDownRe.Value = value; }
        }
        public decimal Im
        {
            get { return numericUpDownIm.Value; }
            set { numericUpDownIm.Value = value; }
        }
        public string Nazwa
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public decimal StopienRe
        {
            get { return numericUpDownRe.Increment; }
            set { numericUpDownRe.Increment = value; }
        }
        public decimal StopienIm
        {
            get { return numericUpDownIm.Increment; }
            set { numericUpDownIm.Increment = value; }
        }
        public bool EdytowalneRe
        {
            get { return numericUpDownRe.Enabled; }
            set { numericUpDownRe.Enabled = value; }
        }
        public bool EdytowalneIm
        {
            get { return numericUpDownIm.Enabled; }
            set { numericUpDownIm.Enabled = value; }
        }
        public UserControlLiczbaZespolona()
        {
            InitializeComponent();
        }
    }
}
