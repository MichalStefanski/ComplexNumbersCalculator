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
    public partial class UserControlVectorDisplay : UserControl
    {
        private static int center_x, center_y;

        private Graphics graph = null;
        private float zoom = 1f;
        private Pen blackPen = new Pen(Color.Black, 3);
        private Pen redPen = new Pen(Color.Red, 3);
        private Pen bluePen = new Pen(Color.Blue, 3);
        private Pen greenPen = new Pen(Color.Green, 3);

        public decimal CoordRe = 100;
        public decimal CoordIn = 100;

        public UserControlVectorDisplay()
        {
            InitializeComponent();
            center_x = panelVectorDisplay.Width / 2;
            center_y = panelVectorDisplay.Height / 2;
        }
        
        private void panelVectorDisplay_Paint(object sender, PaintEventArgs e)
        {
            graph = e.Graphics;
            graph.ScaleTransform(zoom, zoom);
            DrawVector(center_x, 0, center_x, panelVectorDisplay.Height, blackPen); // y axis
            DrawVector(0, center_y, panelVectorDisplay.Width, center_y, blackPen); // x axis
            DrawXPoint();
            DrawYPoint();
            DrawABPoint();
        }

        private void DrawVector(int startX, int startY, int endX, int endY, Pen pen)
        {
            Point[] points =
            {
                new Point(startX, startY),
                new Point(endX, endY)
            };

            graph.DrawLines(pen, points);
        }
        
        private void DrawXPoint()
        {
            int coord_X = Convert.ToInt32(CoordRe);
            graph.DrawEllipse(bluePen, center_x + coord_X, center_y, 3, 3);            
        }

        private void DrawYPoint()
        {
            int coord_Y = Convert.ToInt32(CoordIn);

            graph.DrawEllipse(redPen, center_x, center_y - coord_Y, 3, 3);
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            if (zoom < 1.5)
            {
                zoom = zoom + 0.1f;
                panelVectorDisplay.Invalidate();
            }
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            if (zoom > 1)
            {
                zoom = zoom - 0.1f;
                panelVectorDisplay.Invalidate();
            }            
        }

        private void DrawABPoint()
        {
            int coord_X = Convert.ToInt32(CoordRe);
            int coord_Y = Convert.ToInt32(CoordIn);
            int coorx = center_x + 100;
            int coory = center_y - 100;

            graph.DrawEllipse(greenPen, center_x + coord_X, center_y - coord_Y, 3, 3);
            graph.DrawLine(greenPen, center_x, center_y, coorx, coory);
        }
    }
}
