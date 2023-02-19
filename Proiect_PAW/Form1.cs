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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFilme_Click(object sender, EventArgs e)
        {
            Filme film = new Filme();
            film.ShowDialog();
        }

        private void buttonClienti_Click(object sender, EventArgs e)
        {
            Clienti client = new Clienti();
            client.ShowDialog();
        }

        private void buttonInchirieri_Click(object sender, EventArgs e)
        {
            InchirieriForm i = new InchirieriForm();
            i.ShowDialog();
        }
    }
}
