namespace _4955_Kalkulator_liczb_Zespolonych
{
    partial class UserControlVectorChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartVectorDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonZIn = new System.Windows.Forms.Button();
            this.buttonZOut = new System.Windows.Forms.Button();
            this.checkBoxLabel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartVectorDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVectorDisplay
            // 
            this.chartVectorDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea";
            this.chartVectorDisplay.ChartAreas.Add(chartArea1);
            this.chartVectorDisplay.Location = new System.Drawing.Point(25, 5);
            this.chartVectorDisplay.Name = "chartVectorDisplay";
            this.chartVectorDisplay.Size = new System.Drawing.Size(350, 325);
            this.chartVectorDisplay.TabIndex = 0;
            // 
            // buttonZIn
            // 
            this.buttonZIn.Location = new System.Drawing.Point(115, 371);
            this.buttonZIn.Name = "buttonZIn";
            this.buttonZIn.Size = new System.Drawing.Size(75, 23);
            this.buttonZIn.TabIndex = 1;
            this.buttonZIn.Text = "Zoom In";
            this.buttonZIn.UseVisualStyleBackColor = true;
            this.buttonZIn.Click += new System.EventHandler(this.buttonZIn_Click);
            // 
            // buttonZOut
            // 
            this.buttonZOut.Location = new System.Drawing.Point(205, 371);
            this.buttonZOut.Name = "buttonZOut";
            this.buttonZOut.Size = new System.Drawing.Size(75, 23);
            this.buttonZOut.TabIndex = 2;
            this.buttonZOut.Text = "Zoom Out";
            this.buttonZOut.UseVisualStyleBackColor = true;
            this.buttonZOut.Click += new System.EventHandler(this.buttonZOut_Click);
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Checked = true;
            this.checkBoxLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLabel.Location = new System.Drawing.Point(158, 348);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(87, 17);
            this.checkBoxLabel.TabIndex = 3;
            this.checkBoxLabel.Text = "Show Labels";
            this.checkBoxLabel.UseVisualStyleBackColor = true;
            this.checkBoxLabel.CheckedChanged += new System.EventHandler(this.checkBoxLabel_CheckedChanged);
            // 
            // UserControlVectorChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxLabel);
            this.Controls.Add(this.buttonZOut);
            this.Controls.Add(this.buttonZIn);
            this.Controls.Add(this.chartVectorDisplay);
            this.Name = "UserControlVectorChart";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.chartVectorDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVectorDisplay;
        private System.Windows.Forms.Button buttonZIn;
        private System.Windows.Forms.Button buttonZOut;
        private System.Windows.Forms.CheckBox checkBoxLabel;
    }
}
