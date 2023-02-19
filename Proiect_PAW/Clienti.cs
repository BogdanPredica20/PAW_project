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
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
            Client c1 = new Client("Mircea", "Alexandru",22, "1990406285668", "Craiova");
            Client c2 = new Client("Militaru", "Andreea", 31, "2891215129052", "Cluj");
            Client c3 = new Client("Sandu", "Cosmin", 45, "1123154129052", "Bucuresti");

            ListViewItem lv1 = new ListViewItem(c1.nume);
            lv1.SubItems.Add(c1.prenume);
            lv1.SubItems.Add(c1.varsta.ToString());
            lv1.SubItems.Add(c1.cnp);
            lv1.SubItems.Add(c1.oras);

            lv1.Tag = c1;

            ListViewItem lv2 = new ListViewItem(c2.nume);
            lv2.SubItems.Add(c2.prenume);
            lv2.SubItems.Add(c2.varsta.ToString());
            lv2.SubItems.Add(c2.cnp);
            lv2.SubItems.Add(c2.oras);

            lv2.Tag = c2;

            ListViewItem lv3 = new ListViewItem(c3.nume);
            lv3.SubItems.Add(c3.prenume);
            lv3.SubItems.Add(c3.varsta.ToString());
            lv3.SubItems.Add(c3.cnp);
            lv3.SubItems.Add(c3.oras);

            lv3.Tag = c1;

            listView1.Items.Add(lv1);
            listView1.Items.Add(lv2);
            listView1.Items.Add(lv3);
        }

        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                Client c = (Client)lvi.Tag;
                lvi.Text = c.nume;
                lvi.SubItems[1].Text = c.prenume;
                lvi.SubItems[2].Text = c.varsta.ToString();
                lvi.SubItems[3].Text = c.cnp;
                lvi.SubItems[4].Text = c.oras;
            }
        }

        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "","" });
            listView1.Items.Add(lvi);
            lvi.Selected = true;
            Client c = new Client();
            lvi.Tag = c;
            Detalii_clienti dc = new Detalii_clienti();
            dc.client = c;
            dc.parinte = this;
            dc.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                stergeClientToolStripMenuItem.Enabled = true;
                adaugaClientToolStripMenuItem.Enabled = false;
            }
            else
            {
                adaugaClientToolStripMenuItem.Enabled = true;
                stergeClientToolStripMenuItem.Enabled = false;
            }
        }

        private void adaugaClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugaClientToolStripMenuItem_Click(sender, e);
        }

        private void stergeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Client c = (Client)listView1.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea clientului " + c.nume + " " + c.prenume + "?",
                     "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (rezultat == DialogResult.Yes)
                    listView1.SelectedItems[0].Remove();
            }
        }
    }
}
