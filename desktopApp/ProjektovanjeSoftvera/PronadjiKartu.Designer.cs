namespace ProjektovanjeSoftvera
{
    partial class PronadjiKartu
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            this.buttonPronadji = new System.Windows.Forms.Button();
            this.textBoxIdKarte = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPlati = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.textBoxPolazak = new System.Windows.Forms.TextBox();
            this.textBoxDolazak = new System.Windows.Forms.TextBox();
            this.textBoxTrasa = new System.Windows.Forms.TextBox();
            this.textBoxVremePolaska = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxPopust = new System.Windows.Forms.TextBox();
            this.textBoxAktivna = new System.Windows.Forms.TextBox();
            this.textBoxPovratna = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 13);
            label1.TabIndex = 2;
            label1.Text = "Id karte :";
            // 
            // buttonPronadji
            // 
            this.buttonPronadji.Location = new System.Drawing.Point(167, 4);
            this.buttonPronadji.Name = "buttonPronadji";
            this.buttonPronadji.Size = new System.Drawing.Size(75, 23);
            this.buttonPronadji.TabIndex = 0;
            this.buttonPronadji.Text = "Pronadji";
            this.buttonPronadji.UseVisualStyleBackColor = true;
            this.buttonPronadji.Click += new System.EventHandler(this.buttonPronadji_Click);
            // 
            // textBoxIdKarte
            // 
            this.textBoxIdKarte.Location = new System.Drawing.Point(61, 6);
            this.textBoxIdKarte.Name = "textBoxIdKarte";
            this.textBoxIdKarte.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdKarte.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPovratna);
            this.groupBox1.Controls.Add(this.textBoxAktivna);
            this.groupBox1.Controls.Add(this.textBoxPopust);
            this.groupBox1.Controls.Add(this.textBoxCena);
            this.groupBox1.Controls.Add(this.textBoxVremePolaska);
            this.groupBox1.Controls.Add(this.textBoxTrasa);
            this.groupBox1.Controls.Add(this.textBoxDolazak);
            this.groupBox1.Controls.Add(this.textBoxPolazak);
            this.groupBox1.Controls.Add(label10);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.buttonPonisti);
            this.groupBox1.Controls.Add(this.buttonPlati);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o karti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 3;
            label2.Text = "Dolazak :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 4;
            label3.Text = "Polazak :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 5;
            label4.Text = "Trasa :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 130);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 13);
            label5.TabIndex = 6;
            label5.Text = "Cena :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 13);
            label6.TabIndex = 7;
            label6.Text = "Vreme polaska :";
            // 
            // buttonPlati
            // 
            this.buttonPlati.Location = new System.Drawing.Point(9, 235);
            this.buttonPlati.Name = "buttonPlati";
            this.buttonPlati.Size = new System.Drawing.Size(75, 23);
            this.buttonPlati.TabIndex = 8;
            this.buttonPlati.Text = "Plati kartu";
            this.buttonPlati.UseVisualStyleBackColor = true;
            this.buttonPlati.Click += new System.EventHandler(this.buttonPlati_Click);
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Location = new System.Drawing.Point(154, 235);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(75, 23);
            this.buttonPonisti.TabIndex = 9;
            this.buttonPonisti.Text = "Izbriši kartu";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.buttonPonisti_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 156);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 13);
            label8.TabIndex = 11;
            label8.Text = "Popust :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(6, 182);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(49, 13);
            label9.TabIndex = 12;
            label9.Text = "Aktivna :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 208);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 13);
            label10.TabIndex = 13;
            label10.Text = "Povratna :";
            // 
            // textBoxPolazak
            // 
            this.textBoxPolazak.Location = new System.Drawing.Point(88, 23);
            this.textBoxPolazak.Name = "textBoxPolazak";
            this.textBoxPolazak.ReadOnly = true;
            this.textBoxPolazak.Size = new System.Drawing.Size(136, 20);
            this.textBoxPolazak.TabIndex = 14;
            // 
            // textBoxDolazak
            // 
            this.textBoxDolazak.Location = new System.Drawing.Point(88, 49);
            this.textBoxDolazak.Name = "textBoxDolazak";
            this.textBoxDolazak.ReadOnly = true;
            this.textBoxDolazak.Size = new System.Drawing.Size(136, 20);
            this.textBoxDolazak.TabIndex = 15;
            // 
            // textBoxTrasa
            // 
            this.textBoxTrasa.Location = new System.Drawing.Point(88, 75);
            this.textBoxTrasa.Name = "textBoxTrasa";
            this.textBoxTrasa.ReadOnly = true;
            this.textBoxTrasa.Size = new System.Drawing.Size(136, 20);
            this.textBoxTrasa.TabIndex = 16;
            // 
            // textBoxVremePolaska
            // 
            this.textBoxVremePolaska.Location = new System.Drawing.Point(88, 101);
            this.textBoxVremePolaska.Name = "textBoxVremePolaska";
            this.textBoxVremePolaska.ReadOnly = true;
            this.textBoxVremePolaska.Size = new System.Drawing.Size(136, 20);
            this.textBoxVremePolaska.TabIndex = 17;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(88, 127);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.ReadOnly = true;
            this.textBoxCena.Size = new System.Drawing.Size(136, 20);
            this.textBoxCena.TabIndex = 18;
            // 
            // textBoxPopust
            // 
            this.textBoxPopust.Location = new System.Drawing.Point(88, 153);
            this.textBoxPopust.Name = "textBoxPopust";
            this.textBoxPopust.ReadOnly = true;
            this.textBoxPopust.Size = new System.Drawing.Size(136, 20);
            this.textBoxPopust.TabIndex = 19;
            // 
            // textBoxAktivna
            // 
            this.textBoxAktivna.Location = new System.Drawing.Point(88, 179);
            this.textBoxAktivna.Name = "textBoxAktivna";
            this.textBoxAktivna.ReadOnly = true;
            this.textBoxAktivna.Size = new System.Drawing.Size(136, 20);
            this.textBoxAktivna.TabIndex = 20;
            // 
            // textBoxPovratna
            // 
            this.textBoxPovratna.Location = new System.Drawing.Point(88, 205);
            this.textBoxPovratna.Name = "textBoxPovratna";
            this.textBoxPovratna.ReadOnly = true;
            this.textBoxPovratna.Size = new System.Drawing.Size(136, 20);
            this.textBoxPovratna.TabIndex = 21;
            // 
            // PronadjiKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxIdKarte);
            this.Controls.Add(this.buttonPronadji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PronadjiKartu";
            this.Text = "PronadjiKartu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPronadji;
        private System.Windows.Forms.TextBox textBoxIdKarte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPovratna;
        private System.Windows.Forms.TextBox textBoxAktivna;
        private System.Windows.Forms.TextBox textBoxPopust;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxVremePolaska;
        private System.Windows.Forms.TextBox textBoxTrasa;
        private System.Windows.Forms.TextBox textBoxDolazak;
        private System.Windows.Forms.TextBox textBoxPolazak;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.Button buttonPlati;
    }
}