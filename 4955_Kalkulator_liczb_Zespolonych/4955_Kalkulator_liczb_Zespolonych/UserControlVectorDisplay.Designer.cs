namespace _4955_Kalkulator_liczb_Zespolonych
{
    partial class UserControlVectorDisplay
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
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.panelVectorDisplay = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZoomIn.Location = new System.Drawing.Point(459, 152);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(65, 25);
            this.buttonZoomIn.TabIndex = 1;
            this.buttonZoomIn.Text = "Zoom In";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZoomOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonZoomOut.Location = new System.Drawing.Point(459, 183);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(65, 25);
            this.buttonZoomOut.TabIndex = 0;
            this.buttonZoomOut.Text = "Zoom Out";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // panelVectorDisplay
            // 
            this.panelVectorDisplay.AutoScroll = true;
            this.panelVectorDisplay.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panelVectorDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelVectorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVectorDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVectorDisplay.Location = new System.Drawing.Point(3, 16);
            this.panelVectorDisplay.Name = "panelVectorDisplay";
            this.panelVectorDisplay.Size = new System.Drawing.Size(450, 330);
            this.panelVectorDisplay.TabIndex = 2;
            this.panelVectorDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVectorDisplay_Paint);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panelVectorDisplay);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(453, 349);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // UserControlVectorDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonZoomOut);
            this.Controls.Add(this.buttonZoomIn);
            this.Name = "UserControlVectorDisplay";
            this.Size = new System.Drawing.Size(544, 369);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Panel panelVectorDisplay;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
