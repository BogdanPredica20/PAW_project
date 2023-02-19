
namespace Proiect_PAW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFilme = new System.Windows.Forms.Button();
            this.buttonClienti = new System.Windows.Forms.Button();
            this.buttonInchirieri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFilme
            // 
            this.buttonFilme.Location = new System.Drawing.Point(103, 195);
            this.buttonFilme.Name = "buttonFilme";
            this.buttonFilme.Size = new System.Drawing.Size(120, 23);
            this.buttonFilme.TabIndex = 1;
            this.buttonFilme.Text = "Lista filme";
            this.buttonFilme.UseVisualStyleBackColor = true;
            this.buttonFilme.Click += new System.EventHandler(this.buttonFilme_Click);
            // 
            // buttonClienti
            // 
            this.buttonClienti.Location = new System.Drawing.Point(278, 195);
            this.buttonClienti.Name = "buttonClienti";
            this.buttonClienti.Size = new System.Drawing.Size(113, 23);
            this.buttonClienti.TabIndex = 2;
            this.buttonClienti.Text = "Lista clienti";
            this.buttonClienti.UseVisualStyleBackColor = true;
            this.buttonClienti.Click += new System.EventHandler(this.buttonClienti_Click);
            // 
            // buttonInchirieri
            // 
            this.buttonInchirieri.Location = new System.Drawing.Point(445, 195);
            this.buttonInchirieri.Name = "buttonInchirieri";
            this.buttonInchirieri.Size = new System.Drawing.Size(97, 23);
            this.buttonInchirieri.TabIndex = 3;
            this.buttonInchirieri.Text = "Inchirieri";
            this.buttonInchirieri.UseVisualStyleBackColor = true;
            this.buttonInchirieri.Click += new System.EventHandler(this.buttonInchirieri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 312);
            this.Controls.Add(this.buttonInchirieri);
            this.Controls.Add(this.buttonClienti);
            this.Controls.Add(this.buttonFilme);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonFilme;
        private System.Windows.Forms.Button buttonClienti;
        private System.Windows.Forms.Button buttonInchirieri;
    }
}

