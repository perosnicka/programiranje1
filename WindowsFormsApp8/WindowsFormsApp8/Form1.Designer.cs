namespace WindowsFormsApp8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odpriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.dlg1 = new System.Windows.Forms.SaveFileDialog();
            this.operacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180FlipNone = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270FlipNone = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(405, 235);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(716, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(32, 452);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 465);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(713, 26);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.operacijeToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odpriToolStripMenuItem,
            this.shraniToolStripMenuItem,
            this.izhodToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // odpriToolStripMenuItem
            // 
            this.odpriToolStripMenuItem.Name = "odpriToolStripMenuItem";
            this.odpriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odpriToolStripMenuItem.Text = "Odpri";
            this.odpriToolStripMenuItem.Click += new System.EventHandler(this.odpriToolStripMenuItem_Click);
            // 
            // shraniToolStripMenuItem
            // 
            this.shraniToolStripMenuItem.Name = "shraniToolStripMenuItem";
            this.shraniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shraniToolStripMenuItem.Text = "Shrani";
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izhodToolStripMenuItem.Text = "Izhod";
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            this.dlg.Filter = "Slike (*.jpg,*.bmp)|*.jpg;*.bmp|Vse datoteke (*.*)|*.* ";
            // 
            // dlg1
            // 
            this.dlg1.Filter = "Slike (*.jpg,*.bmp)|*.jpg;*.bmp|Vse datoteke (*.*)|*.* ";
            // 
            // operacijeToolStripMenuItem
            // 
            this.operacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate180FlipNone,
            this.Rotate270FlipNone});
            this.operacijeToolStripMenuItem.Name = "operacijeToolStripMenuItem";
            this.operacijeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.operacijeToolStripMenuItem.Text = "Operacije";
            // 
            // Rotate180FlipNone
            // 
            this.Rotate180FlipNone.Name = "Rotate180FlipNone";
            this.Rotate180FlipNone.Size = new System.Drawing.Size(180, 22);
            this.Rotate180FlipNone.Text = "Zavrti za 180";
            // 
            // Rotate270FlipNone
            // 
            this.Rotate270FlipNone.Name = "Rotate270FlipNone";
            this.Rotate270FlipNone.Size = new System.Drawing.Size(180, 22);
            this.Rotate270FlipNone.Text = "Zavrti za 270";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Fotografije";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odpriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.SaveFileDialog dlg1;
        private System.Windows.Forms.ToolStripMenuItem operacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotate180FlipNone;
        private System.Windows.Forms.ToolStripMenuItem Rotate270FlipNone;
    }
}

