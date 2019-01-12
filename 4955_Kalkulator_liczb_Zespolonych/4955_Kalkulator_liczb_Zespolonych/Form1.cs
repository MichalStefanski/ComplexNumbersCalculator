using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _4955_LICZBY_ZESPOLONE;

namespace _4955_Kalkulator_liczb_Zespolonych
{
    public partial class Form1 : Form
    {
        List<LiczbaZespolona> zespolonas = new List<LiczbaZespolona>();
        bool TrigonometryChecked;
        bool CoordinatesChecked;
        bool CannonicChecked;
        
        public Form1()
        {
            InitializeComponent();
            this.userControlOprationType.SwitchEvent += MainWindow_switchEvent;
            this.scoreDisplay1.PresentationEvent += MainWindow_presentationEvent;
            CoordinatesChecked = true;
            ClearWhole();
        }

        // Wyświetla wyniki w jednej z trzech postaci
        private void MainWindow_presentationEvent(object sender, EventArgs e)
        {
            CoordinatesChecked = scoreDisplay1.RadioButton1IsChecked;
            TrigonometryChecked = scoreDisplay1.RadioButton2IsChecked;
            CannonicChecked = scoreDisplay1.RadioButton3IsChecked;
            ScoreDisplayF(zespolonas);
        }

        // Przełączanie poiędzy typem operacji
        void MainWindow_switchEvent(object sender, EventArgs e)
        {
            HideUseless();
        }
        
        // Formatowanie wyniku do jednej z trzech postaci
        private void ScoreDisplayF(List<LiczbaZespolona> list)
        {
            RooTofComplex complex = new RooTofComplex();
            StringBuilder builder = new StringBuilder();
            LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
            if (TrigonometryChecked)
            {
                scoreDisplay1.TextBoxScoreText = "";
                for (int i = 0; i < list.Count; i++)
                {
                    builder.AppendLine("W" + i + " = " + complex.Trigon(list[i], z1, Convert.ToDouble(1/numericUpDownRoot.Value)));
                }                
            }
            else if (CoordinatesChecked)
            {
                scoreDisplay1.TextBoxScoreText = "";
                for (int i = 0; i < list.Count; i++)
                {
                    builder.AppendLine("W" + i + " = " + list[i].ToString());
                }
            }
            else if (CannonicChecked)
            {
                scoreDisplay1.TextBoxScoreText = "";
                for (int i = 0; i < list.Count; i++)
                {
                    builder.AppendLine("W" + i + " = " + complex.Canonic(list[i]));
                }
            }
            scoreDisplay1.TextBoxScoreText = builder.ToString();
        }

        // Ukrywanie zbędnych elementów pomiędzy trybami pracy kalkulatora
        private void HideUseless()
        {
            if (userControlOprationType.IsOn1 == false && userControlOprationType.IsOn2 == true)  // tryb operacji
            {
                ButtonDodaj.Text = "Pierwiastkuj";
                buttonOdejmnij.Visible = false;
                buttonMnóż.Visible = false;
                buttonDziel.Visible = false;
                userControlLiczbaZespolonaZ2.Visible = false;
                scoreDisplay1.Location = new Point(25, 185);
                scoreDisplay1.TextBoxScoreHeight = 125;
                scoreDisplay1.GroupBox1Height = 220;
                StopienPierwiastka.Visible = true;
                buttonCzysc.Location = new Point(413, 134);
                numericUpDownRoot.Minimum = 2;
                numericUpDownRoot.Value = 2;
            }   
            
            else if (userControlOprationType.IsOn1 == true && userControlOprationType.IsOn2 == false)  // tryb pierwiastkowania
            {
                ButtonDodaj.Text = "Dodaj";
                buttonOdejmnij.Visible = true;
                buttonMnóż.Visible = true;
                buttonDziel.Visible = true;
                userControlLiczbaZespolonaZ2.Visible = true;
                scoreDisplay1.Location = new Point(25, 290);
                scoreDisplay1.TextBoxScoreHeight = 20;
                scoreDisplay1.GroupBox1Height = 115;
                StopienPierwiastka.Visible = false;
                buttonCzysc.Location = new Point(413, 261);
                numericUpDownRoot.Minimum = 1;
                numericUpDownRoot.Value = 1;
            }
        }

        // Czyszczenie formatki - funkcja
        private void ClearWhole()
        {
            userControlLiczbaZespolonaZ1.Re = 0;
            userControlLiczbaZespolonaZ1.Im = 0;
            userControlLiczbaZespolonaZ2.Re = 0;
            userControlLiczbaZespolonaZ2.Im = 0;
            numericUpDownRoot.Value = 2;

            LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
            LiczbaZespolona z2 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ2.Re, (double)userControlLiczbaZespolonaZ2.Im);
            LiczbaZespolona z3 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ2.Re, (double)userControlLiczbaZespolonaZ2.Im);
            userControlVectorChart1.FillChartElemOp(z1, z2, z3);
            zespolonas.Clear();            
        }

        // pełni dwie funkcje - dodawanie w op. artymetycznych i pierwiastkowanie
        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            if (userControlOprationType.IsOn1 == true && userControlOprationType.IsOn2 == false)
            {
                LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
                LiczbaZespolona z2 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ2.Re, (double)userControlLiczbaZespolonaZ2.Im);
                zespolonas.Clear();
                zespolonas.Add(z1 + z2);
                ScoreDisplayF(zespolonas);
                userControlVectorChart1.FillChartElemOp(z1, z2, zespolonas[0]);
            }
            else if (userControlOprationType.IsOn1 == false && userControlOprationType.IsOn2 == true)
            {
                LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
                RooTofComplex rooTofComplex = new RooTofComplex();
                int root = (int)numericUpDownRoot.Value;
                zespolonas.Clear();
                for (int i = 0; i < root; i++)
                {
                    zespolonas.Add(rooTofComplex.Rownanie(z1, root, i));
                }
                ScoreDisplayF(zespolonas);
                userControlVectorChart1.FillChartRotOp(zespolonas);
            }
        }

        private void buttonMnóż_Click(object sender, EventArgs e)
        {
            LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
            LiczbaZespolona z2 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ2.Re, (double)userControlLiczbaZespolonaZ2.Im);
            zespolonas.Clear();
            zespolonas.Add(z1 * z2);
            ScoreDisplayF(zespolonas);
            userControlVectorChart1.FillChartElemOp(z1, z2, zespolonas[0]);
        }

        private void buttonDziel_Click(object sender, EventArgs e)
        {
            LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
            LiczbaZespolona z2 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ2.Re, (double)userControlLiczbaZespolonaZ2.Im);
            zespolonas.Clear();
            zespolonas.Add(z1 / z2);
            ScoreDisplayF(zespolonas);
            if ((Math.Pow(z2.Re, 2) + Math.Pow(z2.Im, 2)) != 0)
            {
                userControlVectorChart1.FillChartElemOp(z1, z2, zespolonas[0]);
            }            
        }

        private void buttonOdejmnij_Click(object sender, EventArgs e)
        {
            LiczbaZespolona z1 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ1.Re, (double)userControlLiczbaZespolonaZ1.Im);
            LiczbaZespolona z2 = new LiczbaZespolona((double)userControlLiczbaZespolonaZ2.Re, (double)userControlLiczbaZespolonaZ2.Im);
            zespolonas.Clear();
            zespolonas.Add(z1 - z2);
            ScoreDisplayF(zespolonas);
            userControlVectorChart1.FillChartElemOp(z1, z2, zespolonas[0]);
        }

        private void buttonCzysc_Click(object sender, EventArgs e)
        {
            ClearWhole();
        }
    }
}
