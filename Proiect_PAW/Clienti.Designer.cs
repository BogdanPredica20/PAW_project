
namespace Proiect_PAW
{
    partial class Clienti
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Oras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Varsta,
            this.CNP,
            this.Oras});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(514, 265);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaClientToolStripMenuItem
            // 
            this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.adaugaClientToolStripMenuItem.Text = "Adauga Client";
            this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 100;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 100;
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            // 
            // CNP
            // 
            this.CNP.Text = "CNP";
            this.CNP.Width = 150;
            // 
            // Oras
            // 
            this.Oras.Text = "Oras";
            this.Oras.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem1,
            this.stergeClientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaClientToolStripMenuItem1
            // 
            this.adaugaClientToolStripMenuItem1.Name = "adaugaClientToolStripMenuItem1";
            this.adaugaClientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adaugaClientToolStripMenuItem1.Text = "Adauga Client";
            this.adaugaClientToolStripMenuItem1.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem1_Click);
            // 
            // stergeClientToolStripMenuItem
            // 
            this.stergeClientToolStripMenuItem.Name = "stergeClientToolStripMenuItem";
            this.stergeClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeClientToolStripMenuItem.Text = "Sterge Client";
            this.stergeClientToolStripMenuItem.Click += new System.EventHandler(this.stergeClientToolStripMenuItem_Click);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 376);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clienti";
            this.Text = "Clienti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Varsta;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader Oras;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeClientToolStripMenuItem;
    }
}