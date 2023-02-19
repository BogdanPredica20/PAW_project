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
    public partial class Detalii_clienti : Form
    {
        public Client client;
        public Clienti parinte;
        public Detalii_clienti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.nume = textBoxNume.Text;
            client.prenume = textBoxPrenume.Text;
            client.varsta = Convert.ToInt32(textBoxVarsta.Text);
            client.cnp = textBoxCNP.Text;
            client.oras = textBoxOras.Text;
            this.parinte.UpdateItems();
            this.Close();
        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNume.Text.Length < 1)
            {
                errorProvider1.SetError(textBoxNume, "Trebuie adaugat un nume");
                e.Cancel = true;
            }
             else
                errorProvider1.SetError(textBoxNume, "");
        }

        private void textBoxPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrenume.Text.Length < 1)
            {
                errorProvider1.SetError(textBoxPrenume, "Trebuie adaugat un prenume");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBoxPrenume, "");
        }
    }
}
