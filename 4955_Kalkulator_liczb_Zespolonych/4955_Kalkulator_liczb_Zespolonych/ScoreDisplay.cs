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
    public partial class ScoreDisplay : UserControl
    {
        public event EventHandler PresentationEvent;
        
        public ScrollBars TextBoxScrollBars
        {
            get { return textBoxScore.ScrollBars; }
            set { textBoxScore.ScrollBars = value; }
        }
        public string TextBoxScoreText
        {
            get { return textBoxScore.Text; }
            set { textBoxScore.Text = value; }
        }
        public string GroupBox1Text
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }
        public string GroupBox2Text
        {
            get { return groupBox2.Text; }
            set { groupBox2.Text = value; }
        }
        public string RadioButton1Text
        {
            get { return radioButton1.Text; }
            set { radioButton1.Text = value; }
        }
        public string RadioButton2Text
        {
            get { return radioButton2.Text; }
            set { radioButton2.Text = value; }
        }
        public string RadioButton3Text
        {
            get { return radioButton3.Text; }
            set { radioButton3.Text = value; }
        }
        public bool RadioButton1IsChecked
        {
            get {return radioButton1.Checked; }
            set { radioButton1.Checked = value; }
        }
        public bool RadioButton2IsChecked
        {
            get { return radioButton2.Checked; }
            set { radioButton2.Checked = value; }
        }
        public bool RadioButton3IsChecked
        {
            get { return radioButton3.Checked; }
            set { radioButton3.Checked = value; }
        }
        public int TextBoxScoreHeight
        {
            get { return textBoxScore.Height; }
            set { textBoxScore.Height = value; }
        }
        public int GroupBox1Height
        {
            get { return groupBox1.Height; }
            set { groupBox1.Height = value; }
        }

        public ScoreDisplay()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (PresentationEvent != null)
            {
                PresentationEvent(null, null);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (PresentationEvent != null)
            {
                PresentationEvent(null, null);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (PresentationEvent != null)
            {
                PresentationEvent(null, null);
            }
        }
    }
}
