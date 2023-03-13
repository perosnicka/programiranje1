namespace Izpit2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGBP = new System.Windows.Forms.RadioButton();
            this.radJPY = new System.Windows.Forms.RadioButton();
            this.radUSD = new System.Windows.Forms.RadioButton();
            this.textVnos = new System.Windows.Forms.TextBox();
            this.textRezultat = new System.Windows.Forms.TextBox();
            this.lblVnos = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.brnIzracun = new System.Windows.Forms.Button();
            this.btnPocisti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGBP);
            this.groupBox1.Controls.Add(this.radJPY);
            this.groupBox1.Controls.Add(this.radUSD);
            this.groupBox1.Location = new System.Drawing.Point(67, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpTečaji";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radGBP
            // 
            this.radGBP.AutoSize = true;
            this.radGBP.Location = new System.Drawing.Point(6, 65);
            this.radGBP.Name = "radGBP";
            this.radGBP.Size = new System.Drawing.Size(47, 17);
            this.radGBP.TabIndex = 3;
            this.radGBP.Text = "GBP";
            this.radGBP.UseVisualStyleBackColor = true;
            this.radGBP.CheckedChanged += new System.EventHandler(this.radGBP_CheckedChanged);
            // 
            // radJPY
            // 
            this.radJPY.AutoSize = true;
            this.radJPY.Location = new System.Drawing.Point(6, 42);
            this.radJPY.Name = "radJPY";
            this.radJPY.Size = new System.Drawing.Size(44, 17);
            this.radJPY.TabIndex = 2;
            this.radJPY.Text = "JPY";
            this.radJPY.UseVisualStyleBackColor = true;
            this.radJPY.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radUSD
            // 
            this.radUSD.AutoSize = true;
            this.radUSD.Checked = true;
            this.radUSD.Location = new System.Drawing.Point(6, 19);
            this.radUSD.Name = "radUSD";
            this.radUSD.Size = new System.Drawing.Size(48, 17);
            this.radUSD.TabIndex = 1;
            this.radUSD.TabStop = true;
            this.radUSD.Text = "USD";
            this.radUSD.UseVisualStyleBackColor = true;
            this.radUSD.CheckedChanged += new System.EventHandler(this.radUSD_CheckedChanged);
            // 
            // textVnos
            // 
            this.textVnos.Location = new System.Drawing.Point(261, 56);
            this.textVnos.Name = "textVnos";
            this.textVnos.Size = new System.Drawing.Size(100, 20);
            this.textVnos.TabIndex = 1;
            this.textVnos.TextChanged += new System.EventHandler(this.textVnos_TextChanged);
            // 
            // textRezultat
            // 
            this.textRezultat.Location = new System.Drawing.Point(261, 105);
            this.textRezultat.Name = "textRezultat";
            this.textRezultat.Size = new System.Drawing.Size(100, 20);
            this.textRezultat.TabIndex = 2;
            this.textRezultat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblVnos
            // 
            this.lblVnos.AutoSize = true;
            this.lblVnos.Location = new System.Drawing.Point(378, 61);
            this.lblVnos.Name = "lblVnos";
            this.lblVnos.Size = new System.Drawing.Size(30, 13);
            this.lblVnos.TabIndex = 3;
            this.lblVnos.Text = "EUR";
            this.lblVnos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(378, 112);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(30, 13);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "USD";
            this.lblRezultat.Click += new System.EventHandler(this.lblRezultat_Click);
            // 
            // brnIzracun
            // 
            this.brnIzracun.Location = new System.Drawing.Point(85, 232);
            this.brnIzracun.Name = "brnIzracun";
            this.brnIzracun.Size = new System.Drawing.Size(75, 23);
            this.brnIzracun.TabIndex = 5;
            this.brnIzracun.Text = "Izračunaj";
            this.brnIzracun.UseVisualStyleBackColor = true;
            this.brnIzracun.Click += new System.EventHandler(this.brnIzracun_Click);
            // 
            // btnPocisti
            // 
            this.btnPocisti.Location = new System.Drawing.Point(261, 232);
            this.btnPocisti.Name = "btnPocisti";
            this.btnPocisti.Size = new System.Drawing.Size(75, 23);
            this.btnPocisti.TabIndex = 6;
            this.btnPocisti.Text = "Počisti";
            this.btnPocisti.UseVisualStyleBackColor = true;
            this.btnPocisti.Click += new System.EventHandler(this.btnPocisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPocisti);
            this.Controls.Add(this.brnIzracun);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblVnos);
            this.Controls.Add(this.textRezultat);
            this.Controls.Add(this.textVnos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Izpit2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radJPY;
        private System.Windows.Forms.RadioButton radUSD;
        private System.Windows.Forms.RadioButton radGBP;
        private System.Windows.Forms.TextBox textVnos;
        private System.Windows.Forms.TextBox textRezultat;
        private System.Windows.Forms.Label lblVnos;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Button brnIzracun;
        private System.Windows.Forms.Button btnPocisti;
    }
}

