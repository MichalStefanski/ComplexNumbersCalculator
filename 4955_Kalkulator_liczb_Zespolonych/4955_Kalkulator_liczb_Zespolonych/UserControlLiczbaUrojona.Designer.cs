namespace _4955_Kalkulator_liczb_Zespolonych
{
    partial class UserControlLiczbaUrojona
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownRe = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIm = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownIm);
            this.groupBox1.Controls.Add(this.numericUpDownRe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Re";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Im";
            // 
            // numericUpDownRe
            // 
            this.numericUpDownRe.Location = new System.Drawing.Point(35, 26);
            this.numericUpDownRe.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownRe.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownRe.Name = "numericUpDownRe";
            this.numericUpDownRe.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRe.TabIndex = 2;
            // 
            // numericUpDownIm
            // 
            this.numericUpDownIm.Location = new System.Drawing.Point(35, 64);
            this.numericUpDownIm.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownIm.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownIm.Name = "numericUpDownIm";
            this.numericUpDownIm.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIm.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlLiczbaUrojona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlLiczbaUrojona";
            this.Size = new System.Drawing.Size(578, 287);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIm;
        private System.Windows.Forms.NumericUpDown numericUpDownRe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
