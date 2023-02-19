
namespace Proiect_PAW
{
    partial class Filme
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelListaFilme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumeFilm = new System.Windows.Forms.TextBox();
            this.textBoxGen = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxDurata = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxStoc = new System.Windows.Forms.TextBox();
            this.buttonAdaugaFilm = new System.Windows.Forms.Button();
            this.textBoxDragDrop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGrafic = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(12, 36);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(351, 587);
            this.treeView1.TabIndex = 0;
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeFilmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            // 
            // stergeFilmToolStripMenuItem
            // 
            this.stergeFilmToolStripMenuItem.Name = "stergeFilmToolStripMenuItem";
            this.stergeFilmToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stergeFilmToolStripMenuItem.Text = "Sterge film";
            this.stergeFilmToolStripMenuItem.Click += new System.EventHandler(this.stergeFilmToolStripMenuItem_Click);
            // 
            // labelListaFilme
            // 
            this.labelListaFilme.AutoSize = true;
            this.labelListaFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaFilme.Location = new System.Drawing.Point(126, 9);
            this.labelListaFilme.Name = "labelListaFilme";
            this.labelListaFilme.Size = new System.Drawing.Size(99, 24);
            this.labelListaFilme.TabIndex = 3;
            this.labelListaFilme.Text = "Lista Filme";
            this.labelListaFilme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data premierei";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stoc";
            // 
            // textBoxNumeFilm
            // 
            this.textBoxNumeFilm.Location = new System.Drawing.Point(583, 97);
            this.textBoxNumeFilm.Name = "textBoxNumeFilm";
            this.textBoxNumeFilm.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeFilm.TabIndex = 10;
            // 
            // textBoxGen
            // 
            this.textBoxGen.Location = new System.Drawing.Point(583, 141);
            this.textBoxGen.Name = "textBoxGen";
            this.textBoxGen.Size = new System.Drawing.Size(100, 20);
            this.textBoxGen.TabIndex = 11;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(583, 178);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 12;
            // 
            // textBoxDurata
            // 
            this.textBoxDurata.Location = new System.Drawing.Point(583, 227);
            this.textBoxDurata.Name = "textBoxDurata";
            this.textBoxDurata.Size = new System.Drawing.Size(100, 20);
            this.textBoxDurata.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBoxStoc
            // 
            this.textBoxStoc.Location = new System.Drawing.Point(583, 311);
            this.textBoxStoc.Name = "textBoxStoc";
            this.textBoxStoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxStoc.TabIndex = 15;
            // 
            // buttonAdaugaFilm
            // 
            this.buttonAdaugaFilm.Location = new System.Drawing.Point(511, 380);
            this.buttonAdaugaFilm.Name = "buttonAdaugaFilm";
            this.buttonAdaugaFilm.Size = new System.Drawing.Size(151, 49);
            this.buttonAdaugaFilm.TabIndex = 16;
            this.buttonAdaugaFilm.Text = "Adauga/Modifica film";
            this.buttonAdaugaFilm.UseVisualStyleBackColor = true;
            this.buttonAdaugaFilm.Click += new System.EventHandler(this.buttonAdaugaFilm_Click);
            // 
            // textBoxDragDrop
            // 
            this.textBoxDragDrop.Location = new System.Drawing.Point(535, 456);
            this.textBoxDragDrop.Name = "textBoxDragDrop";
            this.textBoxDragDrop.Size = new System.Drawing.Size(200, 20);
            this.textBoxDragDrop.TabIndex = 17;
            this.textBoxDragDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxDragDrop_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Drag and drop";
            // 
            // buttonGrafic
            // 
            this.buttonGrafic.Location = new System.Drawing.Point(476, 526);
            this.buttonGrafic.Name = "buttonGrafic";
            this.buttonGrafic.Size = new System.Drawing.Size(151, 23);
            this.buttonGrafic.TabIndex = 19;
            this.buttonGrafic.Text = "Deschide grafic";
            this.buttonGrafic.UseVisualStyleBackColor = true;
            this.buttonGrafic.Click += new System.EventHandler(this.buttonGrafic_Click);
            // 
            // Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 702);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonGrafic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDragDrop);
            this.Controls.Add(this.buttonAdaugaFilm);
            this.Controls.Add(this.textBoxStoc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxDurata);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.textBoxGen);
            this.Controls.Add(this.textBoxNumeFilm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListaFilme);
            this.Controls.Add(this.treeView1);
            this.Name = "Filme";
            this.Text = "Filme";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelListaFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumeFilm;
        private System.Windows.Forms.TextBox textBoxGen;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxDurata;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxStoc;
        private System.Windows.Forms.Button buttonAdaugaFilm;
        private System.Windows.Forms.ToolStripMenuItem stergeFilmToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxDragDrop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGrafic;
    }
}