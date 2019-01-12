using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _4955_Kalkulator_liczb_Zespolonych
{
    partial class UserControlVectorChart : UserControl
    {
        public bool Checked
        {
            get { return checkBoxLabel.Checked; }
            set { checkBoxLabel.Checked = value; }
        }
                
        private Series Z1 = new Series();
        private Series Z2 = new Series();
        private Series ZW = new Series();

        private ArrowAnnotation myLineZW = new ArrowAnnotation();
        private ArrowAnnotation myLineZ1 = new ArrowAnnotation();
        private ArrowAnnotation myLineZ2 = new ArrowAnnotation();

        public UserControlVectorChart()
        {
            InitializeComponent();            

            // Punkt przeciecia osi x,y
            chartVectorDisplay.ChartAreas[0].AxisX.Crossing = 0;
            chartVectorDisplay.ChartAreas[0].AxisY.Crossing = 0;
            
            // Siatka wykresu
            chartVectorDisplay.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartVectorDisplay.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chartVectorDisplay.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartVectorDisplay.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Zakończenie osi x,y
            chartVectorDisplay.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            chartVectorDisplay.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Triangle;

            // Nazwy osi X, Y
            chartVectorDisplay.ChartAreas[0].AxisX.Title = "Re";
            chartVectorDisplay.ChartAreas[0].AxisY.Title = "Im";
        }

        // Wypełnienie wykresu dla operacji elementarnych
        public void FillChartElemOp(_4955_LICZBY_ZESPOLONE.LiczbaZespolona z1, _4955_LICZBY_ZESPOLONE.LiczbaZespolona z2, _4955_LICZBY_ZESPOLONE.LiczbaZespolona zw)
        {
            chartVectorDisplay.Series.Clear();
            chartVectorDisplay.Annotations.Clear();

            ZW.Points.Clear();
            Z1.Points.Clear();
            Z2.Points.Clear();

            // Serie danych
            Z1.Points.AddXY(z1.Re, z1.Im);
            Z2.Points.AddXY(z2.Re, z2.Im);
            ZW.Points.AddXY(zw.Re, zw.Im);
            chartVectorDisplay.Series.Add(Z1);
            chartVectorDisplay.Series.Add(Z2);
            chartVectorDisplay.Series.Add(ZW);
            Z1.ChartType = SeriesChartType.Point;
            Z2.ChartType = SeriesChartType.Point;
            ZW.ChartType = SeriesChartType.Point;
            
            
            ZW.CustomProperties = "IsXAxisQuantitative = true";
            Z1.CustomProperties = "IsXAxisQuantitative = true";
            Z2.CustomProperties = "IsXAxisQuantitative = true";

            // Annotacje
            myLineZW.LineColor = Color.Green;
            myLineZ1.LineColor = Color.Blue;
            myLineZ2.LineColor = Color.Red;

            myLineZW.IsSizeAlwaysRelative = false;
            myLineZ1.IsSizeAlwaysRelative = false;
            myLineZ2.IsSizeAlwaysRelative = false;

            myLineZW.LineWidth = 2;
            myLineZ1.LineWidth = 2;
            myLineZ2.LineWidth = 2;

            myLineZW.ArrowSize = 1;
            myLineZ1.ArrowSize = 1;
            myLineZ2.ArrowSize = 1;

            myLineZW.AllowResizing = false;
            myLineZ1.AllowResizing = false;
            myLineZ2.AllowResizing = false;
                       
            myLineZW.AnchorDataPoint = ZW.Points[0];
            myLineZW.Width = -zw.Re;
            myLineZW.Height = -zw.Im;

            myLineZ1.AnchorDataPoint = Z1.Points[0];
            myLineZ1.Width = -z1.Re;
            myLineZ1.Height = -z1.Im;

            myLineZ2.AnchorDataPoint = Z2.Points[0];
            myLineZ2.Width = -z2.Re;
            myLineZ2.Height = -z2.Im;

            chartVectorDisplay.Annotations.Add(myLineZW);
            chartVectorDisplay.Annotations.Add(myLineZ1);
            chartVectorDisplay.Annotations.Add(myLineZ2);
        }

        // Wypełnienie wykresu dla pierwiastków
        public void FillChartRotOp(List<_4955_LICZBY_ZESPOLONE.LiczbaZespolona> list)
        {
            chartVectorDisplay.Series.Clear();
            chartVectorDisplay.Annotations.Clear();
            List<ArrowAnnotation> arrowAnnotations = new List<ArrowAnnotation>();

            ZW.Points.Clear();
            Z1.Points.Clear();
            Z2.Points.Clear();

            chartVectorDisplay.Series.Add(Z1);
            chartVectorDisplay.Series.Add(Z2);
            chartVectorDisplay.Series.Add(ZW);
            ZW.ChartType = SeriesChartType.Point;

            ZW.CustomProperties = "IsXAxisQuantitative = false";

            for (int i = 0; i < list.Count; i++)
            {                
                arrowAnnotations.Add(new ArrowAnnotation());
                arrowAnnotations[i].IsSizeAlwaysRelative = false;
                arrowAnnotations[i].LineColor = Color.Black;
                arrowAnnotations[i].LineWidth = 2;
                arrowAnnotations[i].ArrowSize = 1;
                arrowAnnotations[i].AllowResizing = false;
                ZW.Points.AddXY(list[i].Re, list[i].Im);
                arrowAnnotations[i].AnchorDataPoint = ZW.Points[i];
                arrowAnnotations[i].Width = -list[i].Re;
                arrowAnnotations[i].Height = -list[i].Im;
                chartVectorDisplay.Annotations.Add(arrowAnnotations[i]);
            }
        }

        // Powiększanie wykresu
        private void buttonZIn_Click(object sender, EventArgs e)
        {
            Axis ax = chartVectorDisplay.ChartAreas[0].AxisX;
            Axis ay = chartVectorDisplay.ChartAreas[0].AxisY;
            ax.ScaleView.Size = double.IsNaN(ax.ScaleView.Size) ?
                                (ax.Maximum - ax.Minimum) * 0.8 : ax.ScaleView.Size *= 0.8;
            ay.ScaleView.Size = double.IsNaN(ay.ScaleView.Size) ?
                                (ay.Maximum - ay.Minimum) * 0.8 : ay.ScaleView.Size *= 0.8;
        }
        
        // Pomniejszanie wykresu
        private void buttonZOut_Click(object sender, EventArgs e)
        {
            Axis ax = chartVectorDisplay.ChartAreas[0].AxisX;
            Axis ay = chartVectorDisplay.ChartAreas[0].AxisY;
            ax.ScaleView.Size = double.IsNaN(ax.ScaleView.Size) ?
                                ax.Maximum : ax.ScaleView.Size /= 0.8;
            ay.ScaleView.Size = double.IsNaN(ay.ScaleView.Size) ?
                                (ay.Maximum - ay.Minimum) / 0.8 : ay.ScaleView.Size /= 0.8;            
        }

        //Wyswietlanie etykiet danych
        private void checkBoxLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLabel.Checked == true)
            {
                if (ZW.Points.Count == 0)
                {
                    Z1.Label = null;
                    Z2.Label = null;
                    ZW.Label = null;
                }
                else if (ZW.Points.Count == 1)
                {
                    if (Z1.Points[0].XValue == 0 && Z1.Points[0].YValues[0] == 0 && Z2.Points[0].XValue == 0 && Z2.Points[0].YValues[0] == 0)
                    {
                        Z1.Label = null;
                        Z2.Label = null;
                        ZW.Label = "(#VALX, #VALY)";
                    }
                    else
                    {
                        Z1.Label = "(#VALX, #VALY)";
                        Z2.Label = "(#VALX, #VALY)";
                        ZW.Label = "(#VALX, #VALY)";
                    }
                }
                else
                {
                    Z1.Label = null;
                    Z2.Label = null;
                    ZW.Label = "(#VALX, #VALY)";
                }
            }
            else if (checkBoxLabel.Checked == false)
            {
                Z1.Label = null;
                Z2.Label = null;
                ZW.Label = null;
            }
        }    
    }
}
