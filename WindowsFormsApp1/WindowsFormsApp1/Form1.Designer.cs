namespace WindowsFormsApp1
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
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnBarva = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(96, 42);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(264, 20);
            this.txtVnos.TabIndex = 0;
            // 
            // btnBarva
            // 
            this.btnBarva.Location = new System.Drawing.Point(96, 126);
            this.btnBarva.Name = "btnBarva";
            this.btnBarva.Size = new System.Drawing.Size(75, 23);
            this.btnBarva.TabIndex = 1;
            this.btnBarva.Text = "Barva";
            this.btnBarva.UseVisualStyleBackColor = true;
            this.btnBarva.Click += new System.EventHandler(this.btnBarva_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(285, 125);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Pisava";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 256);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnBarva);
            this.Controls.Add(this.txtVnos);
            this.Name = "Form1";
            this.Text = "Kolokvij23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnBarva;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

