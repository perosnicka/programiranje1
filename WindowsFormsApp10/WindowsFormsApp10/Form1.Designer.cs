namespace WindowsFormsApp10
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
            this.grpTecaj = new System.Windows.Forms.GroupBox();
            this.radGBP = new System.Windows.Forms.RadioButton();
            this.radJPY = new System.Windows.Forms.RadioButton();
            this.radUSD = new System.Windows.Forms.RadioButton();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnPocisti = new System.Windows.Forms.Button();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.lblVnos = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpTecaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTecaj
            // 
            this.grpTecaj.Controls.Add(this.radGBP);
            this.grpTecaj.Controls.Add(this.radJPY);
            this.grpTecaj.Controls.Add(this.radUSD);
            this.grpTecaj.Location = new System.Drawing.Point(48, 40);
            this.grpTecaj.Name = "grpTecaj";
            this.grpTecaj.Size = new System.Drawing.Size(207, 192);
            this.grpTecaj.TabIndex = 0;
            this.grpTecaj.TabStop = false;
            this.grpTecaj.Text = "Tečaj";
            // 
            // radGBP
            // 
            this.radGBP.AutoSize = true;
            this.radGBP.Location = new System.Drawing.Point(21, 102);
            this.radGBP.Name = "radGBP";
            this.radGBP.Size = new System.Drawing.Size(47, 17);
            this.radGBP.TabIndex = 2;
            this.radGBP.TabStop = true;
            this.radGBP.Text = "GBP";
            this.radGBP.UseVisualStyleBackColor = true;
            // 
            // radJPY
            // 
            this.radJPY.AutoSize = true;
            this.radJPY.Location = new System.Drawing.Point(21, 64);
            this.radJPY.Name = "radJPY";
            this.radJPY.Size = new System.Drawing.Size(44, 17);
            this.radJPY.TabIndex = 1;
            this.radJPY.TabStop = true;
            this.radJPY.Text = "JPY";
            this.radJPY.UseVisualStyleBackColor = true;
            // 
            // radUSD
            // 
            this.radUSD.AutoSize = true;
            this.radUSD.Location = new System.Drawing.Point(21, 29);
            this.radUSD.Name = "radUSD";
            this.radUSD.Size = new System.Drawing.Size(48, 17);
            this.radUSD.TabIndex = 0;
            this.radUSD.TabStop = true;
            this.radUSD.Text = "USD";
            this.radUSD.UseVisualStyleBackColor = true;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(37, 288);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 1;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnPocisti
            // 
            this.btnPocisti.Location = new System.Drawing.Point(211, 288);
            this.btnPocisti.Name = "btnPocisti";
            this.btnPocisti.Size = new System.Drawing.Size(75, 23);
            this.btnPocisti.TabIndex = 2;
            this.btnPocisti.Text = "Počisti";
            this.btnPocisti.UseVisualStyleBackColor = true;
            this.btnPocisti.Click += new System.EventHandler(this.btnPocisti_Click);
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(304, 60);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(100, 20);
            this.txtVnos.TabIndex = 3;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(304, 104);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(100, 20);
            this.txtRezultat.TabIndex = 4;
            // 
            // lblVnos
            // 
            this.lblVnos.AutoSize = true;
            this.lblVnos.Location = new System.Drawing.Point(432, 66);
            this.lblVnos.Name = "lblVnos";
            this.lblVnos.Size = new System.Drawing.Size(30, 13);
            this.lblVnos.TabIndex = 5;
            this.lblVnos.Text = "EUR";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(435, 110);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(0, 13);
            this.lblRezultat.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Izhod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblVnos);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.btnPocisti);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.grpTecaj);
            this.Name = "Form1";
            this.Text = "Tečajna lista";
            this.grpTecaj.ResumeLayout(false);
            this.grpTecaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTecaj;
        private System.Windows.Forms.RadioButton radGBP;
        private System.Windows.Forms.RadioButton radJPY;
        private System.Windows.Forms.RadioButton radUSD;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnPocisti;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label lblVnos;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Button button1;
    }
}

