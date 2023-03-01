namespace WindowsFormsApp2
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnDvojisko = new System.Windows.Forms.Button();
            this.btnPocisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(207, 80);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 0;
            // 
            // btnDvojisko
            // 
            this.btnDvojisko.Location = new System.Drawing.Point(157, 184);
            this.btnDvojisko.Name = "btnDvojisko";
            this.btnDvojisko.Size = new System.Drawing.Size(75, 23);
            this.btnDvojisko.TabIndex = 1;
            this.btnDvojisko.Text = "Dvojiško";
            this.btnDvojisko.UseVisualStyleBackColor = true;
            this.btnDvojisko.Click += new System.EventHandler(this.btnDvojisko_Click);
            // 
            // btnPocisti
            // 
            this.btnPocisti.Location = new System.Drawing.Point(354, 184);
            this.btnPocisti.Name = "btnPocisti";
            this.btnPocisti.Size = new System.Drawing.Size(75, 23);
            this.btnPocisti.TabIndex = 2;
            this.btnPocisti.Text = "Počisti";
            this.btnPocisti.UseVisualStyleBackColor = true;
            this.btnPocisti.Click += new System.EventHandler(this.btnPocisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 297);
            this.Controls.Add(this.btnPocisti);
            this.Controls.Add(this.btnDvojisko);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Pretvornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnDvojisko;
        private System.Windows.Forms.Button btnPocisti;
    }
}

