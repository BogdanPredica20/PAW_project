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
    public partial class Grafic : Form
    {
        TreeView tv1;
        public Grafic(TreeView tv)
        {
            InitializeComponent();
            tv1 = tv;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float[] sume = new float[tv1.Nodes.Count];

            foreach (TreeNode nodparinte in tv1.Nodes)
            {
                string[] vector = nodparinte.Nodes[2].Text.Split(new char[1] { ':' });
                string nume = nodparinte.Text;

                try
                {
                    sume[nodparinte.Index] = float.Parse(vector[1]);
                }
                catch { }
            }

            for (int i = 0; i < sume.Length; i++)
            {
                int height = (e.ClipRectangle.Height - 10) / sume.Length;
                int width = e.ClipRectangle.Width - 10;
                SolidBrush brush = new SolidBrush(Color.DarkGreen);
                
                Rectangle rect = new Rectangle(5, 5 + i * height, (int)(sume[i] / sume.Max() * width), height - 5);
                //g.DrawRectangle(new Pen(Color.DarkRed), 5, 5 + i * height, sume[i] / sume.Max() * width, height - 5);
                g.FillRectangle(brush, rect);
                
            }
        }
    }
}
