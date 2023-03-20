namespace Express_Paint
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOdpri = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnShrani = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnIzhod = new System.Windows.Forms.ToolStripMenuItem();
            this.vrtenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.zrcaliNavpičnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaliVodoravnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osvetliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potemniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrtenje90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 562);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(870, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(853, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 538);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 538);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.vrtenjeToolStripMenuItem,
            this.zrcaljenjeToolStripMenuItem,
            this.filtriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOdpri,
            this.BtnShrani,
            this.toolStripSeparator1,
            this.BtnIzhod});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // BtnOdpri
            // 
            this.BtnOdpri.Name = "BtnOdpri";
            this.BtnOdpri.Size = new System.Drawing.Size(180, 22);
            this.BtnOdpri.Text = "Odpri";
            this.BtnOdpri.Click += new System.EventHandler(this.BtnOdpri_Click);
            // 
            // BtnShrani
            // 
            this.BtnShrani.Name = "BtnShrani";
            this.BtnShrani.Size = new System.Drawing.Size(180, 22);
            this.BtnShrani.Text = "Shrani";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // BtnIzhod
            // 
            this.BtnIzhod.Name = "BtnIzhod";
            this.BtnIzhod.Size = new System.Drawing.Size(180, 22);
            this.BtnIzhod.Text = "Izhod";
            // 
            // vrtenjeToolStripMenuItem
            // 
            this.vrtenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrtenje90ToolStripMenuItem});
            this.vrtenjeToolStripMenuItem.Name = "vrtenjeToolStripMenuItem";
            this.vrtenjeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vrtenjeToolStripMenuItem.Text = "Vrtenje";
            // 
            // zrcaljenjeToolStripMenuItem
            // 
            this.zrcaljenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zrcaliNavpičnoToolStripMenuItem,
            this.zrcaliVodoravnoToolStripMenuItem});
            this.zrcaljenjeToolStripMenuItem.Name = "zrcaljenjeToolStripMenuItem";
            this.zrcaljenjeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zrcaljenjeToolStripMenuItem.Text = "Zrcaljenje";
            // 
            // filtriToolStripMenuItem
            // 
            this.filtriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativToolStripMenuItem,
            this.osvetliToolStripMenuItem,
            this.potemniToolStripMenuItem});
            this.filtriToolStripMenuItem.Name = "filtriToolStripMenuItem";
            this.filtriToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filtriToolStripMenuItem.Text = "Filtri";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // zrcaliNavpičnoToolStripMenuItem
            // 
            this.zrcaliNavpičnoToolStripMenuItem.Name = "zrcaliNavpičnoToolStripMenuItem";
            this.zrcaliNavpičnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zrcaliNavpičnoToolStripMenuItem.Text = "Zrcali navpično";
            this.zrcaliNavpičnoToolStripMenuItem.Click += new System.EventHandler(this.zrcaliNavpičnoToolStripMenuItem_Click);
            // 
            // zrcaliVodoravnoToolStripMenuItem
            // 
            this.zrcaliVodoravnoToolStripMenuItem.Name = "zrcaliVodoravnoToolStripMenuItem";
            this.zrcaliVodoravnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zrcaliVodoravnoToolStripMenuItem.Text = "Zrcali vodoravno";
            this.zrcaliVodoravnoToolStripMenuItem.Click += new System.EventHandler(this.zrcaliVodoravnoToolStripMenuItem_Click);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // osvetliToolStripMenuItem
            // 
            this.osvetliToolStripMenuItem.Name = "osvetliToolStripMenuItem";
            this.osvetliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osvetliToolStripMenuItem.Text = "Osvetli";
            this.osvetliToolStripMenuItem.Click += new System.EventHandler(this.osvetliToolStripMenuItem_Click);
            // 
            // potemniToolStripMenuItem
            // 
            this.potemniToolStripMenuItem.Name = "potemniToolStripMenuItem";
            this.potemniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.potemniToolStripMenuItem.Text = "Potemni";
            // 
            // vrtenje90ToolStripMenuItem
            // 
            this.vrtenje90ToolStripMenuItem.Name = "vrtenje90ToolStripMenuItem";
            this.vrtenje90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vrtenje90ToolStripMenuItem.Text = "Vrtenje 90";
            this.vrtenje90ToolStripMenuItem.Click += new System.EventHandler(this.vrtenje90ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrtenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnOdpri;
        private System.Windows.Forms.ToolStripMenuItem BtnShrani;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BtnIzhod;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem zrcaliNavpičnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaliVodoravnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osvetliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potemniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrtenje90ToolStripMenuItem;
    }
}

