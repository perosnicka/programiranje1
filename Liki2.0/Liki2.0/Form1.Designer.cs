namespace Liki2._0
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
            this.Stranica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textStranica = new System.Windows.Forms.TextBox();
            this.textObseg = new System.Windows.Forms.TextBox();
            this.textPloscina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPolmer = new System.Windows.Forms.TextBox();
            this.textObsegK = new System.Windows.Forms.TextBox();
            this.textPloscinaK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stranica
            // 
            this.Stranica.AutoSize = true;
            this.Stranica.Location = new System.Drawing.Point(86, 48);
            this.Stranica.Name = "Stranica";
            this.Stranica.Size = new System.Drawing.Size(46, 13);
            this.Stranica.TabIndex = 0;
            this.Stranica.Text = "Stranica\r\n";
            this.Stranica.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obseg kvadrata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ploščina kvadrata";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textStranica
            // 
            this.textStranica.Location = new System.Drawing.Point(225, 48);
            this.textStranica.Name = "textStranica";
            this.textStranica.Size = new System.Drawing.Size(100, 20);
            this.textStranica.TabIndex = 3;
            this.textStranica.Tag = "stranica";
            this.textStranica.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textObseg
            // 
            this.textObseg.Location = new System.Drawing.Point(225, 96);
            this.textObseg.Name = "textObseg";
            this.textObseg.Size = new System.Drawing.Size(100, 20);
            this.textObseg.TabIndex = 4;
            this.textObseg.Tag = "Obseg kvadrata";
            // 
            // textPloscina
            // 
            this.textPloscina.Location = new System.Drawing.Point(225, 135);
            this.textPloscina.Name = "textPloscina";
            this.textPloscina.Size = new System.Drawing.Size(100, 20);
            this.textPloscina.TabIndex = 5;
            this.textPloscina.Tag = "Ploščina kvadrata";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Izračunaj kvadrat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Polmer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obseg kroga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ploščina kroga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textPolmer
            // 
            this.textPolmer.Location = new System.Drawing.Point(225, 270);
            this.textPolmer.Name = "textPolmer";
            this.textPolmer.Size = new System.Drawing.Size(100, 20);
            this.textPolmer.TabIndex = 10;
            this.textPolmer.Tag = "stranica";
            // 
            // textObsegK
            // 
            this.textObsegK.Location = new System.Drawing.Point(225, 315);
            this.textObsegK.Name = "textObsegK";
            this.textObsegK.Size = new System.Drawing.Size(100, 20);
            this.textObsegK.TabIndex = 11;
            this.textObsegK.Tag = "stranica";
            // 
            // textPloscinaK
            // 
            this.textPloscinaK.Location = new System.Drawing.Point(225, 363);
            this.textPloscinaK.Name = "textPloscinaK";
            this.textPloscinaK.Size = new System.Drawing.Size(100, 20);
            this.textPloscinaK.TabIndex = 12;
            this.textPloscinaK.Tag = "stranica";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Izračunaj krog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 477);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textPloscinaK);
            this.Controls.Add(this.textObsegK);
            this.Controls.Add(this.textPolmer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPloscina);
            this.Controls.Add(this.textObseg);
            this.Controls.Add(this.textStranica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stranica);
            this.Name = "Form1";
            this.Text = "Liki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Stranica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStranica;
        private System.Windows.Forms.TextBox textObseg;
        private System.Windows.Forms.TextBox textPloscina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPolmer;
        private System.Windows.Forms.TextBox textObsegK;
        private System.Windows.Forms.TextBox textPloscinaK;
        private System.Windows.Forms.Button button2;
    }
}

