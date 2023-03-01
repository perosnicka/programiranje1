namespace WindowsFormsApp3
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
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.btnPocisti = new System.Windows.Forms.Button();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.grptecaj = new System.Windows.Forms.GroupBox();
            this.radGBP = new System.Windows.Forms.RadioButton();
            this.radCHF = new System.Windows.Forms.RadioButton();
            this.radUSD = new System.Windows.Forms.RadioButton();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvlVnos = new System.Windows.Forms.Label();
            this.lvlRezultat = new System.Windows.Forms.Label();
            this.grptecaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(262, 69);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(181, 20);
            this.txtVnos.TabIndex = 0;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(262, 120);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(181, 20);
            this.txtRezultat.TabIndex = 1;
            // 
            // btnPocisti
            // 
            this.btnPocisti.Location = new System.Drawing.Point(427, 221);
            this.btnPocisti.Name = "btnPocisti";
            this.btnPocisti.Size = new System.Drawing.Size(152, 23);
            this.btnPocisti.TabIndex = 2;
            this.btnPocisti.Text = "Počisti";
            this.btnPocisti.UseVisualStyleBackColor = true;
            this.btnPocisti.Click += new System.EventHandler(this.btnPocisti_Click);
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(33, 221);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(152, 23);
            this.btnIzracun.TabIndex = 3;
            this.btnIzracun.Text = "Izračunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // grptecaj
            // 
            this.grptecaj.Controls.Add(this.radGBP);
            this.grptecaj.Controls.Add(this.radCHF);
            this.grptecaj.Controls.Add(this.radUSD);
            this.grptecaj.Location = new System.Drawing.Point(33, 52);
            this.grptecaj.Name = "grptecaj";
            this.grptecaj.Size = new System.Drawing.Size(173, 136);
            this.grptecaj.TabIndex = 4;
            this.grptecaj.TabStop = false;
            this.grptecaj.Text = "Valute";
            // 
            // radGBP
            // 
            this.radGBP.AutoSize = true;
            this.radGBP.Location = new System.Drawing.Point(7, 68);
            this.radGBP.Name = "radGBP";
            this.radGBP.Size = new System.Drawing.Size(47, 17);
            this.radGBP.TabIndex = 2;
            this.radGBP.TabStop = true;
            this.radGBP.Text = "GBP";
            this.radGBP.UseVisualStyleBackColor = true;
            // 
            // radCHF
            // 
            this.radCHF.AutoSize = true;
            this.radCHF.Location = new System.Drawing.Point(7, 44);
            this.radCHF.Name = "radCHF";
            this.radCHF.Size = new System.Drawing.Size(46, 17);
            this.radCHF.TabIndex = 1;
            this.radCHF.TabStop = true;
            this.radCHF.Text = "CHF";
            this.radCHF.UseVisualStyleBackColor = true;
            // 
            // radUSD
            // 
            this.radUSD.AutoSize = true;
            this.radUSD.Location = new System.Drawing.Point(7, 20);
            this.radUSD.Name = "radUSD";
            this.radUSD.Size = new System.Drawing.Size(48, 17);
            this.radUSD.TabIndex = 0;
            this.radUSD.TabStop = true;
            this.radUSD.Text = "USD";
            this.radUSD.UseVisualStyleBackColor = true;
            // 
            // btnIzhod
            // 
            this.btnIzhod.Location = new System.Drawing.Point(224, 221);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(152, 23);
            this.btnIzhod.TabIndex = 5;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lvlVnos
            // 
            this.lvlVnos.AutoSize = true;
            this.lvlVnos.Location = new System.Drawing.Point(491, 75);
            this.lvlVnos.Name = "lvlVnos";
            this.lvlVnos.Size = new System.Drawing.Size(30, 13);
            this.lvlVnos.TabIndex = 7;
            this.lvlVnos.Text = "EUR";
            // 
            // lvlRezultat
            // 
            this.lvlRezultat.AutoSize = true;
            this.lvlRezultat.Location = new System.Drawing.Point(484, 126);
            this.lvlRezultat.Name = "lvlRezultat";
            this.lvlRezultat.Size = new System.Drawing.Size(0, 13);
            this.lvlRezultat.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 284);
            this.Controls.Add(this.lvlRezultat);
            this.Controls.Add(this.lvlVnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.grptecaj);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.btnPocisti);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtVnos);
            this.Name = "Form1";
            this.Text = "Tečajna lista";
            this.grptecaj.ResumeLayout(false);
            this.grptecaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button btnPocisti;
        private System.Windows.Forms.Button btnIzracun;
        private System.Windows.Forms.GroupBox grptecaj;
        private System.Windows.Forms.RadioButton radGBP;
        private System.Windows.Forms.RadioButton radCHF;
        private System.Windows.Forms.RadioButton radUSD;
        private System.Windows.Forms.Button btnIzhod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lvlVnos;
        private System.Windows.Forms.Label lvlRezultat;
    }
}

