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
    public partial class UserControlVectors : UserControl
    {
        private Graphics graph;

        public UserControlVectors()
        {
            InitializeComponent();
        }

        private void UserControlVectors_Paint(object sender, PaintEventArgs e)
        {
            graph = e.Graphics;
        }
    }
}
