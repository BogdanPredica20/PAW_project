using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_PAW
{
    public partial class InchirieriForm : Form
    {
        Client c1 = new Client("Mircea", "Alexandru", 22, "1990406285668", "Craiova");
        Client c2 = new Client("Militaru", "Andreea", 31, "2891215129052", "Cluj");
        Client c3 = new Client("Sandu", "Cosmin", 45, "1123154129052", "Bucuresti");
        Film f1 = new Film("The Irishman", "Politist/Drama", 'R', 209, new DateTime(2019, 11, 27), 5);
        Film f2 = new Film("The Shining", "Horror/Drama", 'R', 156, new DateTime(1980, 06, 13), 2);
        Film f3 = new Film("The Godfather", "Crima/Drama", 'R', 179, new DateTime(1972, 03, 14), 4);

        int check;
        
        public InchirieriForm()
        {
            InitializeComponent();
            comboBoxNumeClient.Items.Add(c1.nume);
            comboBoxNumeClient.Items.Add(c2.nume);
            comboBoxNumeClient.Items.Add(c3.nume);

            comboBoxFilm.Items.Add(f1.nume_film);
            comboBoxFilm.Items.Add(f2.nume_film);
            comboBoxFilm.Items.Add(f3.nume_film);

            Inchirieri i1 = new Inchirieri(c1, f3, 30, DateTime.Now, 3);

            check = i1.verifica_stoc();
            if (check != 0)
            {
                ListViewItem lv1 = new ListViewItem(i1.client.nume + " " + i1.client.prenume);
                lv1.SubItems.Add(i1.film.nume_film);
                lv1.SubItems.Add(i1.pret.ToString());
                lv1.SubItems.Add(i1.data_inchirierii.ToString());
                lv1.SubItems.Add(i1.durata_inchirierii.ToString());

                lv1.Tag = i1;
                listView1.Items.Add(lv1);
                i1.film.stoc--;
            }
        }

        private void buttonAdaugaInch_Click(object sender, EventArgs e)
        { 
                ListViewItem lvi = new ListViewItem(comboBoxNumeClient.Text);
                lvi.SubItems.Add(comboBoxFilm.Text);
                lvi.SubItems.Add(textBoxPret.Text);
                lvi.SubItems.Add(dateTimePicker1.Value.ToString());
                lvi.SubItems.Add(textBoxDurata.Text);

                listView1.Items.Add(lvi);

            comboBoxFilm.Text = String.Empty;
            comboBoxNumeClient.Text = String.Empty;
            textBoxDurata.Text = String.Empty;
            textBoxPret.Text = String.Empty;
        }

        private void salveazaInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var file = new System.IO.StreamWriter("C:/Users/user/source/repos/Proiect_PAW/Inchirieri.txt"))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                        file.Write(subitem.Text + ",");
                    file.WriteLine();
                }
                MessageBox.Show("Fisierul text a fost creat");
            }
        }

        private void recupereazaDinFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
                foreach (string line in File.ReadLines("C:/Users/user/source/repos/Proiect_PAW/Inchirieri.txt"))
                {
                    string[] columns = line.Split(',');
                        ListViewItem lvi = new ListViewItem(columns[0]);
                        lvi.SubItems.Add(columns[1]);
                        lvi.SubItems.Add(columns[2]);
                        lvi.SubItems.Add(columns[3]);
                        lvi.SubItems.Add(columns[4]);

                        listView1.Items.Add(lvi);
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float Offset = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {

                e.Graphics.DrawString("Clientul " + listView1.Items[i].SubItems[0].Text + " a cumparat filmul " + listView1.Items[i].SubItems[1].Text
                    + " la data de " + listView1.Items[i].SubItems[3].Text + " si are de platit " + listView1.Items[i].SubItems[2].Text + " de lei",
                  new Font("Arial Bold", 11),
                  new SolidBrush(Color.Black), 50, 50 + Offset);

                Offset = Offset + 20;
            }


        }
    }
}
