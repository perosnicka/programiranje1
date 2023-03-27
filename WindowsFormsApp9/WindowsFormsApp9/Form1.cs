using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fileexploder
{
    public partial class Form1 : Form
    {
        enum ItemType { Mapa, Datoteka };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NaložiDrevo();
        }

        public void NaložiDrevo()
        { //ustvari listo logicnih enot, vsakemu vozlu doda en
          // vozel "kar tako", da se pred vozlom pojavi znak +
            treeView1.Nodes.Clear();
            foreach (string imeD in Directory.GetLogicalDrives())
            {
                TreeNode vozel = treeView1.Nodes.Add(imeD);
                vozel.Nodes.Add("");
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                DodajMape(e.Node);
                DodajDatoteke(e.Node);
            }
            catch (IOException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text);
            }
        }

        private void DodajMape(TreeNode vozel)
        {
            string pot = vozel.FullPath;
            foreach (string imeM in Directory.GetDirectories(pot))
            {
                TreeNode noviV = vozel.Nodes.Add(Path.GetFileName(imeM));
                noviV.Nodes.Add("");
                noviV.Tag = ItemType.Mapa;
            }
        }

        private void DodajDatoteke(TreeNode vozel)
        {
            string pot = vozel.FullPath;
            foreach (string imeM in Directory.GetFiles(pot))
            {
                TreeNode noviV = vozel.Nodes.Add(Path.GetFileName(imeM));
                noviV.Nodes.Add("");
                noviV.Tag = ItemType.Datoteka;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is ItemType)
            {
                switch ((ItemType)e.Node.Tag)
                {
                    case ItemType.Datoteka:
                        FileInfo f = new FileInfo(e.Node.FullPath);
                        textBox1.Text = "" + f.Attributes;
                        textBox2.Text = "" + f.CreationTime;
                        textBox3.Text = "" + f.LastAccessTime;
                        textBox4.Text = "" + f.LastWriteTime;
                        textBox5.Text = "" + f.Extension;
                        textBox6.Text = "" + f.FullName;
                        textBox7.Text = "" + f.Name;
                        textBox8.Text = "" + f.Directory;
                        textBox9.Text = "" + f.DirectoryName;
                        textBox10.Text = "" + f.Length;
                        break;
                    case ItemType.Mapa:
                        DirectoryInfo d = new DirectoryInfo(e.Node.FullPath);
                        textBox1.Text = "" + d.Attributes;
                        textBox2.Text = "" + d.CreationTime;
                        textBox3.Text = "" + d.LastAccessTime;
                        textBox4.Text = "" + d.LastWriteTime;
                        textBox5.Text = "" + d.Extension;
                        textBox6.Text = "" + d.FullName;
                        textBox7.Text = "" + d.Name;
                        textBox8.Text = "" + e.Node.Text;
                        textBox9.Text = "" + e.Node.FullPath;
                        textBox10.Enabled = false;
                        label10.Enabled = false;
                        break;
                    default:
                        //pocistite vsebine spodnjega dela okna
                        break;
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                DodajMape(e.Node);
                DodajDatoteke(e.Node);
            }
            catch (IOException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text);
            }
        }

        private void izpisiLastnosti()
        {

        }
    }
}