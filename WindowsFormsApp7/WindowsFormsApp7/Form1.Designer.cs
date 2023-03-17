namespace WindowsFormsApp7
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
            this.btnOzadje = new System.Windows.Forms.Button();
            this.txtOzadje = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOspredje = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOzadje);
            this.groupBox1.Controls.Add(this.txtOzadje);
            this.groupBox1.Location = new System.Drawing.Point(34, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ImeBarve";
            // 
            // btnOzadje
            // 
            this.btnOzadje.Location = new System.Drawing.Point(206, 34);
            this.btnOzadje.Name = "btnOzadje";
            this.btnOzadje.Size = new System.Drawing.Size(103, 23);
            this.btnOzadje.TabIndex = 1;
            this.btnOzadje.Text = "Nastavi ozadje";
            this.btnOzadje.UseVisualStyleBackColor = true;
            this.btnOzadje.Click += new System.EventHandler(this.btnOzadje_Click);
            // 
            // txtOzadje
            // 
            this.txtOzadje.Location = new System.Drawing.Point(34, 34);
            this.txtOzadje.Name = "txtOzadje";
            this.txtOzadje.Size = new System.Drawing.Size(100, 20);
            this.txtOzadje.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOspredje);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.txt3);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Location = new System.Drawing.Point(34, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barva iz aRGB";
            // 
            // btnOspredje
            // 
            this.btnOspredje.Location = new System.Drawing.Point(354, 35);
            this.btnOspredje.Name = "btnOspredje";
            this.btnOspredje.Size = new System.Drawing.Size(105, 23);
            this.btnOspredje.TabIndex = 4;
            this.btnOspredje.Text = "Nastavi ospredje";
            this.btnOspredje.UseVisualStyleBackColor = true;
            this.btnOspredje.Click += new System.EventHandler(this.btnOspredje_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(270, 35);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(48, 20);
            this.txt4.TabIndex = 3;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(192, 35);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(49, 20);
            this.txt3.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(110, 35);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(55, 20);
            this.txt2.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(34, 35);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(54, 20);
            this.txt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Barve iz aRGB in po imenu";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOzadje;
        private System.Windows.Forms.TextBox txtOzadje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnOspredje;
    }
}

