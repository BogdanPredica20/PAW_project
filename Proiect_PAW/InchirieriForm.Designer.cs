
namespace Proiect_PAW
{
    partial class InchirieriForm
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
            this.Nume_client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Film_inchiriat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_inchirierii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durata_inchirierii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxNumeClient = new System.Windows.Forms.ComboBox();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdaugaInch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recupereazaDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume_client,
            this.Film_inchiriat,
            this.Pret,
            this.Data_inchirierii,
            this.Durata_inchirierii});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 318);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume_client
            // 
            this.Nume_client.Text = "Nume client";
            this.Nume_client.Width = 150;
            // 
            // Film_inchiriat
            // 
            this.Film_inchiriat.Text = "Film inchiriat";
            this.Film_inchiriat.Width = 150;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            // 
            // Data_inchirierii
            // 
            this.Data_inchirierii.Text = "Data inchirierii";
            this.Data_inchirierii.Width = 100;
            // 
            // Durata_inchirierii
            // 
            this.Durata_inchirierii.Text = "Durata inchirierii(zile)";
            this.Durata_inchirierii.Width = 110;
            // 
            // comboBoxNumeClient
            // 
            this.comboBoxNumeClient.FormattingEnabled = true;
            this.comboBoxNumeClient.Location = new System.Drawing.Point(863, 94);
            this.comboBoxNumeClient.Name = "comboBoxNumeClient";
            this.comboBoxNumeClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumeClient.TabIndex = 1;
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Location = new System.Drawing.Point(863, 148);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film inchiriat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data inchirierii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durata (zile)";
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(863, 200);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 20);
            this.textBoxPret.TabIndex = 8;
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.Location = new System.Drawing.Point(863, 294);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.Size = new System.Drawing.Size(100, 20);
            this.textBoxDurata.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(863, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // buttonAdaugaInch
            // 
            this.buttonAdaugaInch.Location = new System.Drawing.Point(789, 358);
            this.buttonAdaugaInch.Name = "buttonAdaugaInch";
            this.buttonAdaugaInch.Size = new System.Drawing.Size(140, 43);
            this.buttonAdaugaInch.TabIndex = 12;
            this.buttonAdaugaInch.Text = "Adauga";
            this.buttonAdaugaInch.UseVisualStyleBackColor = true;
            this.buttonAdaugaInch.Click += new System.EventHandler(this.buttonAdaugaInch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierTextToolStripMenuItem,
            this.recupereazaDinFisierToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaInFisierTextToolStripMenuItem
            // 
            this.salveazaInFisierTextToolStripMenuItem.Name = "salveazaInFisierTextToolStripMenuItem";
            this.salveazaInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.salveazaInFisierTextToolStripMenuItem.Text = "Salveaza in fisier text";
            this.salveazaInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierTextToolStripMenuItem_Click);
            // 
            // recupereazaDinFisierToolStripMenuItem
            // 
            this.recupereazaDinFisierToolStripMenuItem.Name = "recupereazaDinFisierToolStripMenuItem";
            this.recupereazaDinFisierToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.recupereazaDinFisierToolStripMenuItem.Text = "Recupereaza din fisier";
            this.recupereazaDinFisierToolStripMenuItem.Click += new System.EventHandler(this.recupereazaDinFisierToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // InchirieriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonAdaugaInch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxDurata);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.comboBoxNumeClient);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InchirieriForm";
            this.Text = "InchirieriForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume_client;
        private System.Windows.Forms.ColumnHeader Film_inchiriat;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Data_inchirierii;
        private System.Windows.Forms.ColumnHeader Durata_inchirierii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxDurata;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAdaugaInch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recupereazaDinFisierToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBoxNumeClient;
        public System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}