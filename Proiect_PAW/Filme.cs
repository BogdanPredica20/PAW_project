using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Filme : Form
    {
        public Filme()
        {
            int index = 0;
            Film f1 = new Film("The Irishman", "Politist/Drama", 'R',209, new DateTime(2019, 11, 27), 5);
            Film f2 = new Film("The Shining", "Horror/Drama", 'R', 156, new DateTime(1980, 06, 13), 2);
            Film f3 = new Film("The Godfather", "Crima/Drama", 'R', 179, new DateTime(1972, 03, 14), 4);
            InitializeComponent();
            TreeNode nod1 = new TreeNode();
            Adauga_treeview(f1,nod1,index);
            nod1.Name = "Nod1";
            TreeNode nod2 = new TreeNode();
            nod2.Name = "Nod2";
            Adauga_treeview(f2, nod2,index);
            TreeNode nod3 = new TreeNode();
            Adauga_treeview(f3, nod3, index);
            nod3.Name = "Nod3";
        }

        void Adauga_treeview(Film f, TreeNode nod, int i)
        {
            i = treeView1.GetNodeCount(false);
            nod.Text = f.nume_film;
            this.treeView1.Nodes.Add(nod);
            treeView1.Nodes[i].Nodes.Add("Gen: " + f.gen);
            treeView1.Nodes[i].Nodes.Add("Rating: " + f.rating.ToString());
            treeView1.Nodes[i].Nodes.Add("Durata: " + f.durata.ToString());
            treeView1.Nodes[i].Nodes.Add("Data premierei: " + f.data_premierei.ToString());
            treeView1.Nodes[i].Nodes.Add("Stoc: " + f.stoc.ToString());
        }

        private void buttonAdaugaFilm_Click(object sender, EventArgs e)
        {
            TreeNode nod = new TreeNode();
            int i = treeView1.GetNodeCount(false);
            nod.Text = textBoxNumeFilm.Text;
            this.treeView1.Nodes.Add(nod);
            treeView1.Nodes[i].Nodes.Add("Gen: " + textBoxGen.Text);
            treeView1.Nodes[i].Nodes.Add("Rating: " + textBoxRating.Text);
            treeView1.Nodes[i].Nodes.Add("Durata: " + textBoxDurata.Text);
            treeView1.Nodes[i].Nodes.Add("Data premierei: " + dateTimePicker1.Value.ToString());
            treeView1.Nodes[i].Nodes.Add("Stoc: " + textBoxStoc.Text);

            textBoxNumeFilm.Text = String.Empty;
            textBoxGen.Text = String.Empty;
            textBoxRating.Text = String.Empty;
            textBoxDurata.Text = String.Empty;
            textBoxStoc.Text = String.Empty;
        }

        private void stergeFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                TreeNode tn = treeView1.SelectedNode;
                treeView1.Nodes.Remove(tn);
            }
            
        }

        //private void textBoxNumeFilm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    textBoxNumeFilm.SelectAll();

        //    treeView1.DoDragDrop(textBoxNumeFilm.Text, DragDropEffects.Move);
        //}

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            int i = treeView1.GetNodeCount(false);
            e.Effect = DragDropEffects.Move;

            string data = e.Data.GetData(DataFormats.Text).ToString();
            string[] columns = data.Split(',');

            if (columns.Length == 6)
            {
                treeView1.Nodes.Add(columns[0]);
                treeView1.Nodes[i].Nodes.Add("Gen: " + columns[1]);
                treeView1.Nodes[i].Nodes.Add("Rating: " + columns[2]);
                treeView1.Nodes[i].Nodes.Add("Durata: " + columns[3]);
                treeView1.Nodes[i].Nodes.Add("Data premierei: " + columns[4]);
                treeView1.Nodes[i].Nodes.Add("Stoc: " + columns[5]);
            }
            else
                MessageBox.Show("Trebuie introduse 6 valori separate prin virgula!");
        }

        private void textBoxDragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxDragDrop.SelectAll();

            treeView1.DoDragDrop(textBoxDragDrop.Text, DragDropEffects.Move);
        }

        private void buttonGrafic_Click(object sender, EventArgs e)
        {
            Grafic g = new Grafic(treeView1);
            g.Show();
        }
    }
}
