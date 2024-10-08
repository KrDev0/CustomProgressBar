namespace CustomProgressBar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarColor8 = new CustomProgressBar.ProgressBarColor();
            this.progressBarColor6 = new CustomProgressBar.ProgressBarColor();
            this.progressBarColor5 = new CustomProgressBar.ProgressBarColor();
            this.progressBarColor4 = new CustomProgressBar.ProgressBarColor();
            this.progressBarColor3 = new CustomProgressBar.ProgressBarColor();
            this.progressBarColor2 = new CustomProgressBar.ProgressBarColor();
            this.progressBarColor1 = new CustomProgressBar.ProgressBarColor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Color | ProgressBar Control\r\n";
            // 
            // progressBarColor8
            // 
            this.progressBarColor8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarColor8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarColor8.Location = new System.Drawing.Point(120, 348);
            this.progressBarColor8.Name = "progressBarColor8";
            this.progressBarColor8.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor8.TabIndex = 18;
            this.progressBarColor8.Value = 46;
            // 
            // progressBarColor6
            // 
            this.progressBarColor6.BackColor = System.Drawing.Color.White;
            this.progressBarColor6.ForeColor = System.Drawing.Color.White;
            this.progressBarColor6.Location = new System.Drawing.Point(120, 309);
            this.progressBarColor6.Name = "progressBarColor6";
            this.progressBarColor6.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor6.TabIndex = 16;
            this.progressBarColor6.Value = 100;
            // 
            // progressBarColor5
            // 
            this.progressBarColor5.BackColor = System.Drawing.Color.Green;
            this.progressBarColor5.ForeColor = System.Drawing.Color.Green;
            this.progressBarColor5.Location = new System.Drawing.Point(120, 270);
            this.progressBarColor5.Name = "progressBarColor5";
            this.progressBarColor5.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor5.TabIndex = 15;
            this.progressBarColor5.Value = 80;
            // 
            // progressBarColor4
            // 
            this.progressBarColor4.BackColor = System.Drawing.Color.Yellow;
            this.progressBarColor4.ForeColor = System.Drawing.Color.Yellow;
            this.progressBarColor4.Location = new System.Drawing.Point(120, 231);
            this.progressBarColor4.Name = "progressBarColor4";
            this.progressBarColor4.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor4.TabIndex = 14;
            this.progressBarColor4.Value = 19;
            // 
            // progressBarColor3
            // 
            this.progressBarColor3.BackColor = System.Drawing.Color.Black;
            this.progressBarColor3.ForeColor = System.Drawing.Color.Black;
            this.progressBarColor3.Location = new System.Drawing.Point(120, 192);
            this.progressBarColor3.Name = "progressBarColor3";
            this.progressBarColor3.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor3.TabIndex = 13;
            this.progressBarColor3.Value = 60;
            // 
            // progressBarColor2
            // 
            this.progressBarColor2.BackColor = System.Drawing.Color.Red;
            this.progressBarColor2.ForeColor = System.Drawing.Color.Red;
            this.progressBarColor2.Location = new System.Drawing.Point(120, 153);
            this.progressBarColor2.Name = "progressBarColor2";
            this.progressBarColor2.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor2.TabIndex = 12;
            this.progressBarColor2.Value = 35;
            // 
            // progressBarColor1
            // 
            this.progressBarColor1.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBarColor1.Location = new System.Drawing.Point(120, 114);
            this.progressBarColor1.Name = "progressBarColor1";
            this.progressBarColor1.Size = new System.Drawing.Size(560, 33);
            this.progressBarColor1.TabIndex = 11;
            this.progressBarColor1.Value = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarColor8);
            this.Controls.Add(this.progressBarColor6);
            this.Controls.Add(this.progressBarColor5);
            this.Controls.Add(this.progressBarColor4);
            this.Controls.Add(this.progressBarColor3);
            this.Controls.Add(this.progressBarColor2);
            this.Controls.Add(this.progressBarColor1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ProgressBarColor progressBarColor8;
        private ProgressBarColor progressBarColor6;
        private ProgressBarColor progressBarColor5;
        private ProgressBarColor progressBarColor4;
        private ProgressBarColor progressBarColor3;
        private ProgressBarColor progressBarColor2;
        private ProgressBarColor progressBarColor1;
    }
}

