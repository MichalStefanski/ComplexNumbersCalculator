namespace _4955_Kalkulator_liczb_Zespolonych
{
    partial class UserControlMode
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
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonMode2 = new System.Windows.Forms.RadioButton();
            this.radioButtonMode1 = new System.Windows.Forms.RadioButton();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonMode2);
            this.groupBoxMode.Controls.Add(this.radioButtonMode1);
            this.groupBoxMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMode.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(150, 65);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            // 
            // radioButtonMode2
            // 
            this.radioButtonMode2.AutoSize = true;
            this.radioButtonMode2.Location = new System.Drawing.Point(3, 42);
            this.radioButtonMode2.Name = "radioButtonMode2";
            this.radioButtonMode2.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMode2.TabIndex = 3;
            this.radioButtonMode2.UseVisualStyleBackColor = true;
            this.radioButtonMode2.Click += new System.EventHandler(this.radioButtonMode2_Click);
            // 
            // radioButtonMode1
            // 
            this.radioButtonMode1.AutoSize = true;
            this.radioButtonMode1.Checked = true;
            this.radioButtonMode1.Location = new System.Drawing.Point(3, 19);
            this.radioButtonMode1.Name = "radioButtonMode1";
            this.radioButtonMode1.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMode1.TabIndex = 2;
            this.radioButtonMode1.TabStop = true;
            this.radioButtonMode1.UseVisualStyleBackColor = true;
            this.radioButtonMode1.Click += new System.EventHandler(this.radioButtonMode1_Click);
            // 
            // UserControlMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMode);
            this.Name = "UserControlMode";
            this.Size = new System.Drawing.Size(150, 65);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonMode2;
        private System.Windows.Forms.RadioButton radioButtonMode1;
    }
}
