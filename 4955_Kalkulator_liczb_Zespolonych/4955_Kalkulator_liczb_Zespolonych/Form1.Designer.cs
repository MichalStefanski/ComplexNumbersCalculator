namespace _4955_Kalkulator_liczb_Zespolonych
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDodaj = new System.Windows.Forms.Button();
            this.buttonMnóż = new System.Windows.Forms.Button();
            this.buttonDziel = new System.Windows.Forms.Button();
            this.buttonOdejmnij = new System.Windows.Forms.Button();
            this.buttonCzysc = new System.Windows.Forms.Button();
            this.StopienPierwiastka = new System.Windows.Forms.GroupBox();
            this.numericUpDownRoot = new System.Windows.Forms.NumericUpDown();
            this.scoreDisplay1 = new _4955_Kalkulator_liczb_Zespolonych.ScoreDisplay();
            this.userControlOprationType = new _4955_Kalkulator_liczb_Zespolonych.UserControlMode();
            this.userControlVectorChart1 = new _4955_Kalkulator_liczb_Zespolonych.UserControlVectorChart();
            this.userControlLiczbaZespolonaZ2 = new _4955_Kalkulator_liczb_Zespolonych.UserControlLiczbaZespolona();
            this.userControlLiczbaZespolonaZ1 = new _4955_Kalkulator_liczb_Zespolonych.UserControlLiczbaZespolona();
            this.StopienPierwiastka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDodaj
            // 
            this.ButtonDodaj.Location = new System.Drawing.Point(413, 93);
            this.ButtonDodaj.Name = "ButtonDodaj";
            this.ButtonDodaj.Size = new System.Drawing.Size(75, 23);
            this.ButtonDodaj.TabIndex = 8;
            this.ButtonDodaj.Text = "Dodaj";
            this.ButtonDodaj.UseVisualStyleBackColor = true;
            this.ButtonDodaj.Click += new System.EventHandler(this.ButtonDodaj_Click);
            // 
            // buttonMnóż
            // 
            this.buttonMnóż.Location = new System.Drawing.Point(413, 174);
            this.buttonMnóż.Name = "buttonMnóż";
            this.buttonMnóż.Size = new System.Drawing.Size(75, 23);
            this.buttonMnóż.TabIndex = 9;
            this.buttonMnóż.Text = "Mnóż";
            this.buttonMnóż.UseVisualStyleBackColor = true;
            this.buttonMnóż.Click += new System.EventHandler(this.buttonMnóż_Click);
            // 
            // buttonDziel
            // 
            this.buttonDziel.Location = new System.Drawing.Point(413, 218);
            this.buttonDziel.Name = "buttonDziel";
            this.buttonDziel.Size = new System.Drawing.Size(75, 23);
            this.buttonDziel.TabIndex = 10;
            this.buttonDziel.Text = "Dziel";
            this.buttonDziel.UseVisualStyleBackColor = true;
            this.buttonDziel.Click += new System.EventHandler(this.buttonDziel_Click);
            // 
            // buttonOdejmnij
            // 
            this.buttonOdejmnij.Location = new System.Drawing.Point(413, 134);
            this.buttonOdejmnij.Name = "buttonOdejmnij";
            this.buttonOdejmnij.Size = new System.Drawing.Size(75, 23);
            this.buttonOdejmnij.TabIndex = 11;
            this.buttonOdejmnij.Text = "Odejmnij";
            this.buttonOdejmnij.UseVisualStyleBackColor = true;
            this.buttonOdejmnij.Click += new System.EventHandler(this.buttonOdejmnij_Click);
            // 
            // buttonCzysc
            // 
            this.buttonCzysc.Location = new System.Drawing.Point(413, 261);
            this.buttonCzysc.Name = "buttonCzysc";
            this.buttonCzysc.Size = new System.Drawing.Size(75, 23);
            this.buttonCzysc.TabIndex = 15;
            this.buttonCzysc.Text = "Czysc";
            this.buttonCzysc.UseVisualStyleBackColor = true;
            this.buttonCzysc.Click += new System.EventHandler(this.buttonCzysc_Click);
            // 
            // StopienPierwiastka
            // 
            this.StopienPierwiastka.Controls.Add(this.numericUpDownRoot);
            this.StopienPierwiastka.Location = new System.Drawing.Point(180, 10);
            this.StopienPierwiastka.Name = "StopienPierwiastka";
            this.StopienPierwiastka.Size = new System.Drawing.Size(213, 65);
            this.StopienPierwiastka.TabIndex = 19;
            this.StopienPierwiastka.TabStop = false;
            this.StopienPierwiastka.Text = "Stopień Pierwiastka";
            this.StopienPierwiastka.Visible = false;
            // 
            // numericUpDownRoot
            // 
            this.numericUpDownRoot.Location = new System.Drawing.Point(48, 29);
            this.numericUpDownRoot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoot.Name = "numericUpDownRoot";
            this.numericUpDownRoot.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRoot.TabIndex = 0;
            this.numericUpDownRoot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scoreDisplay1
            // 
            this.scoreDisplay1.AutoSize = true;
            this.scoreDisplay1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreDisplay1.GroupBox1Height = 115;
            this.scoreDisplay1.GroupBox1Text = "Wynik";
            this.scoreDisplay1.GroupBox2Text = "Postać liczby zespolonej";
            this.scoreDisplay1.Location = new System.Drawing.Point(25, 290);
            this.scoreDisplay1.MaximumSize = new System.Drawing.Size(360, 230);
            this.scoreDisplay1.MinimumSize = new System.Drawing.Size(360, 125);
            this.scoreDisplay1.Name = "scoreDisplay1";
            this.scoreDisplay1.RadioButton1IsChecked = true;
            this.scoreDisplay1.RadioButton1Text = "Współrzędne";
            this.scoreDisplay1.RadioButton2IsChecked = false;
            this.scoreDisplay1.RadioButton2Text = "Trygonometryczna";
            this.scoreDisplay1.RadioButton3IsChecked = false;
            this.scoreDisplay1.RadioButton3Text = "Kanoniczna";
            this.scoreDisplay1.Size = new System.Drawing.Size(360, 125);
            this.scoreDisplay1.TabIndex = 18;
            this.scoreDisplay1.TextBoxScoreHeight = 20;
            this.scoreDisplay1.TextBoxScoreText = "";
            this.scoreDisplay1.TextBoxScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // userControlOprationType
            // 
            this.userControlOprationType.IsOn1 = true;
            this.userControlOprationType.IsOn2 = false;
            this.userControlOprationType.Location = new System.Drawing.Point(15, 10);
            this.userControlOprationType.Name = "userControlOprationType";
            this.userControlOprationType.Nazwa = "Typ Operacji";
            this.userControlOprationType.Size = new System.Drawing.Size(150, 65);
            this.userControlOprationType.Switch1Name = "Operacje Elementarne";
            this.userControlOprationType.Switch2Name = "Pierwiastkowanie";
            this.userControlOprationType.TabIndex = 17;
            // 
            // userControlVectorChart1
            // 
            this.userControlVectorChart1.Checked = false;
            this.userControlVectorChart1.Location = new System.Drawing.Point(495, 2);
            this.userControlVectorChart1.Name = "userControlVectorChart1";
            this.userControlVectorChart1.Size = new System.Drawing.Size(400, 400);
            this.userControlVectorChart1.TabIndex = 16;
            // 
            // userControlLiczbaZespolonaZ2
            // 
            this.userControlLiczbaZespolonaZ2.EdytowalneIm = true;
            this.userControlLiczbaZespolonaZ2.EdytowalneRe = true;
            this.userControlLiczbaZespolonaZ2.Im = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.userControlLiczbaZespolonaZ2.Location = new System.Drawing.Point(12, 185);
            this.userControlLiczbaZespolonaZ2.Name = "userControlLiczbaZespolonaZ2";
            this.userControlLiczbaZespolonaZ2.Nazwa = "Z2";
            this.userControlLiczbaZespolonaZ2.Re = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.userControlLiczbaZespolonaZ2.Size = new System.Drawing.Size(386, 92);
            this.userControlLiczbaZespolonaZ2.StopienIm = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.userControlLiczbaZespolonaZ2.StopienRe = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.userControlLiczbaZespolonaZ2.TabIndex = 13;
            // 
            // userControlLiczbaZespolonaZ1
            // 
            this.userControlLiczbaZespolonaZ1.EdytowalneIm = true;
            this.userControlLiczbaZespolonaZ1.EdytowalneRe = true;
            this.userControlLiczbaZespolonaZ1.Im = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.userControlLiczbaZespolonaZ1.Location = new System.Drawing.Point(12, 84);
            this.userControlLiczbaZespolonaZ1.Name = "userControlLiczbaZespolonaZ1";
            this.userControlLiczbaZespolonaZ1.Nazwa = "Z1";
            this.userControlLiczbaZespolonaZ1.Re = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.userControlLiczbaZespolonaZ1.Size = new System.Drawing.Size(386, 92);
            this.userControlLiczbaZespolonaZ1.StopienIm = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.userControlLiczbaZespolonaZ1.StopienRe = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.userControlLiczbaZespolonaZ1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 416);
            this.Controls.Add(this.StopienPierwiastka);
            this.Controls.Add(this.scoreDisplay1);
            this.Controls.Add(this.userControlOprationType);
            this.Controls.Add(this.userControlVectorChart1);
            this.Controls.Add(this.buttonCzysc);
            this.Controls.Add(this.userControlLiczbaZespolonaZ2);
            this.Controls.Add(this.userControlLiczbaZespolonaZ1);
            this.Controls.Add(this.buttonOdejmnij);
            this.Controls.Add(this.buttonDziel);
            this.Controls.Add(this.buttonMnóż);
            this.Controls.Add(this.ButtonDodaj);
            this.MaximumSize = new System.Drawing.Size(915, 455);
            this.MinimumSize = new System.Drawing.Size(915, 455);
            this.Name = "Form1";
            this.Text = "Complex Number Calculator";
            this.StopienPierwiastka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonDodaj;
        private System.Windows.Forms.Button buttonMnóż;
        private System.Windows.Forms.Button buttonDziel;
        private System.Windows.Forms.Button buttonOdejmnij;
        private UserControlLiczbaZespolona userControlLiczbaZespolonaZ1;
        private UserControlLiczbaZespolona userControlLiczbaZespolonaZ2;
        private System.Windows.Forms.Button buttonCzysc;
        private UserControlVectorChart userControlVectorChart1;
        private UserControlMode userControlOprationType;
        private ScoreDisplay scoreDisplay1;
        private System.Windows.Forms.GroupBox StopienPierwiastka;
        private System.Windows.Forms.NumericUpDown numericUpDownRoot;
    }
}

