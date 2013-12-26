namespace ProjektovanjeSoftvera
{
    partial class RedVoznje
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
            System.Windows.Forms.GroupBox groupBox5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.buttonIzbrisiRedVoznje = new System.Windows.Forms.Button();
            this.buttonDodajvoznju = new System.Windows.Forms.Button();
            this.textBoxMinut = new System.Windows.Forms.TextBox();
            this.textBoxSat = new System.Windows.Forms.TextBox();
            this.comboBoxDan = new System.Windows.Forms.ComboBox();
            this.comboBoxTrasaIzmeni = new System.Windows.Forms.ComboBox();
            this.comboBoxTrasa = new System.Windows.Forms.ComboBox();
            this.buttonIzbrisiOtkazanaVoznja = new System.Windows.Forms.Button();
            this.comboBoxOtkazaneVoznje = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.buttonSacuvajOtkazaneVoznje = new System.Windows.Forms.Button();
            this.textBoxMinutOtkazi = new System.Windows.Forms.TextBox();
            this.textBoxSatOtkazi = new System.Windows.Forms.TextBox();
            this.comboBoxTrasaOtkazi = new System.Windows.Forms.ComboBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(this.buttonIzbrisiRedVoznje);
            groupBox5.Controls.Add(this.buttonDodajvoznju);
            groupBox5.Controls.Add(this.textBoxMinut);
            groupBox5.Controls.Add(this.textBoxSat);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(this.comboBoxDan);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(this.comboBoxTrasaIzmeni);
            groupBox5.Controls.Add(this.comboBoxTrasa);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new System.Drawing.Point(12, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(337, 222);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dodaj vožnju";
            // 
            // buttonIzbrisiRedVoznje
            // 
            this.buttonIzbrisiRedVoznje.Location = new System.Drawing.Point(99, 181);
            this.buttonIzbrisiRedVoznje.Name = "buttonIzbrisiRedVoznje";
            this.buttonIzbrisiRedVoznje.Size = new System.Drawing.Size(75, 23);
            this.buttonIzbrisiRedVoznje.TabIndex = 15;
            this.buttonIzbrisiRedVoznje.Text = "Izbriši";
            this.buttonIzbrisiRedVoznje.UseVisualStyleBackColor = true;
            this.buttonIzbrisiRedVoznje.Click += new System.EventHandler(this.buttonIzbrisiRedVoznje_Click);
            // 
            // buttonDodajvoznju
            // 
            this.buttonDodajvoznju.Location = new System.Drawing.Point(6, 181);
            this.buttonDodajvoznju.Name = "buttonDodajvoznju";
            this.buttonDodajvoznju.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajvoznju.TabIndex = 14;
            this.buttonDodajvoznju.Text = "Sačuvaj";
            this.buttonDodajvoznju.UseVisualStyleBackColor = true;
            this.buttonDodajvoznju.Click += new System.EventHandler(this.buttonDodajvoznju_Click);
            // 
            // textBoxMinut
            // 
            this.textBoxMinut.Location = new System.Drawing.Point(178, 145);
            this.textBoxMinut.Name = "textBoxMinut";
            this.textBoxMinut.Size = new System.Drawing.Size(54, 20);
            this.textBoxMinut.TabIndex = 13;
            // 
            // textBoxSat
            // 
            this.textBoxSat.Location = new System.Drawing.Point(99, 146);
            this.textBoxSat.Name = "textBoxSat";
            this.textBoxSat.Size = new System.Drawing.Size(54, 20);
            this.textBoxSat.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(159, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 17);
            label3.TabIndex = 11;
            label3.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 13);
            label2.TabIndex = 8;
            label2.Text = "Izaberite vreme:";
            // 
            // comboBoxDan
            // 
            this.comboBoxDan.FormattingEnabled = true;
            this.comboBoxDan.Location = new System.Drawing.Point(99, 111);
            this.comboBoxDan.Name = "comboBoxDan";
            this.comboBoxDan.Size = new System.Drawing.Size(223, 21);
            this.comboBoxDan.TabIndex = 7;
            this.comboBoxDan.Text = "Izaberite...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 13);
            label1.TabIndex = 6;
            label1.Text = "Izaberite dan:";
            // 
            // comboBoxTrasaIzmeni
            // 
            this.comboBoxTrasaIzmeni.FormattingEnabled = true;
            this.comboBoxTrasaIzmeni.Location = new System.Drawing.Point(99, 27);
            this.comboBoxTrasaIzmeni.Name = "comboBoxTrasaIzmeni";
            this.comboBoxTrasaIzmeni.Size = new System.Drawing.Size(223, 21);
            this.comboBoxTrasaIzmeni.TabIndex = 4;
            this.comboBoxTrasaIzmeni.Text = "Izaberite...";
            this.comboBoxTrasaIzmeni.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrasaIzmeni_SelectedIndexChanged);
            // 
            // comboBoxTrasa
            // 
            this.comboBoxTrasa.FormattingEnabled = true;
            this.comboBoxTrasa.Location = new System.Drawing.Point(99, 77);
            this.comboBoxTrasa.Name = "comboBoxTrasa";
            this.comboBoxTrasa.Size = new System.Drawing.Size(223, 21);
            this.comboBoxTrasa.TabIndex = 4;
            this.comboBoxTrasa.Text = "Izaberite...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 30);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(84, 13);
            label8.TabIndex = 1;
            label8.Text = "Izaberite voznju:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 13);
            label4.TabIndex = 1;
            label4.Text = "Izaberite trasu:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.buttonIzbrisiOtkazanaVoznja);
            groupBox2.Controls.Add(this.comboBoxOtkazaneVoznje);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(this.dateTimePickerDatum);
            groupBox2.Controls.Add(this.buttonSacuvajOtkazaneVoznje);
            groupBox2.Controls.Add(this.textBoxMinutOtkazi);
            groupBox2.Controls.Add(this.textBoxSatOtkazi);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(this.comboBoxTrasaOtkazi);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new System.Drawing.Point(12, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(337, 236);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Otkaži vožnju";
            // 
            // buttonIzbrisiOtkazanaVoznja
            // 
            this.buttonIzbrisiOtkazanaVoznja.Location = new System.Drawing.Point(99, 195);
            this.buttonIzbrisiOtkazanaVoznja.Name = "buttonIzbrisiOtkazanaVoznja";
            this.buttonIzbrisiOtkazanaVoznja.Size = new System.Drawing.Size(75, 23);
            this.buttonIzbrisiOtkazanaVoznja.TabIndex = 17;
            this.buttonIzbrisiOtkazanaVoznja.Text = "Izbriši";
            this.buttonIzbrisiOtkazanaVoznja.UseVisualStyleBackColor = true;
            this.buttonIzbrisiOtkazanaVoznja.Click += new System.EventHandler(this.buttonIzbrisiOtkazanaVoznja_Click);
            // 
            // comboBoxOtkazaneVoznje
            // 
            this.comboBoxOtkazaneVoznje.FormattingEnabled = true;
            this.comboBoxOtkazaneVoznje.Location = new System.Drawing.Point(99, 33);
            this.comboBoxOtkazaneVoznje.Name = "comboBoxOtkazaneVoznje";
            this.comboBoxOtkazaneVoznje.Size = new System.Drawing.Size(223, 21);
            this.comboBoxOtkazaneVoznje.TabIndex = 16;
            this.comboBoxOtkazaneVoznje.Text = "Izaberite...";
            this.comboBoxOtkazaneVoznje.SelectedIndexChanged += new System.EventHandler(this.comboBoxOtkazaneVoznje_SelectedIndexChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 36);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 13);
            label5.TabIndex = 15;
            label5.Text = "Otkazane voznje:";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(99, 125);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(223, 20);
            this.dateTimePickerDatum.TabIndex = 5;
            // 
            // buttonSacuvajOtkazaneVoznje
            // 
            this.buttonSacuvajOtkazaneVoznje.Location = new System.Drawing.Point(6, 195);
            this.buttonSacuvajOtkazaneVoznje.Name = "buttonSacuvajOtkazaneVoznje";
            this.buttonSacuvajOtkazaneVoznje.Size = new System.Drawing.Size(75, 23);
            this.buttonSacuvajOtkazaneVoznje.TabIndex = 14;
            this.buttonSacuvajOtkazaneVoznje.Text = "Sačuvaj";
            this.buttonSacuvajOtkazaneVoznje.UseVisualStyleBackColor = true;
            this.buttonSacuvajOtkazaneVoznje.Click += new System.EventHandler(this.buttonSacuvajOtkazaneVoznje_Click);
            // 
            // textBoxMinutOtkazi
            // 
            this.textBoxMinutOtkazi.Location = new System.Drawing.Point(178, 159);
            this.textBoxMinutOtkazi.Name = "textBoxMinutOtkazi";
            this.textBoxMinutOtkazi.Size = new System.Drawing.Size(54, 20);
            this.textBoxMinutOtkazi.TabIndex = 13;
            // 
            // textBoxSatOtkazi
            // 
            this.textBoxSatOtkazi.Location = new System.Drawing.Point(99, 160);
            this.textBoxSatOtkazi.Name = "textBoxSatOtkazi";
            this.textBoxSatOtkazi.Size = new System.Drawing.Size(54, 20);
            this.textBoxSatOtkazi.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(159, 160);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(13, 17);
            label9.TabIndex = 11;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 159);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(82, 13);
            label10.TabIndex = 8;
            label10.Text = "Izaberite vreme:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 125);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(82, 13);
            label11.TabIndex = 6;
            label11.Text = "Izaberite datum:";
            // 
            // comboBoxTrasaOtkazi
            // 
            this.comboBoxTrasaOtkazi.FormattingEnabled = true;
            this.comboBoxTrasaOtkazi.Location = new System.Drawing.Point(99, 91);
            this.comboBoxTrasaOtkazi.Name = "comboBoxTrasaOtkazi";
            this.comboBoxTrasaOtkazi.Size = new System.Drawing.Size(131, 21);
            this.comboBoxTrasaOtkazi.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 95);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(76, 13);
            label12.TabIndex = 1;
            label12.Text = "Izaberite trasu:";
            // 
            // RedVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 520);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RedVoznje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red voznje";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTrasa;
        private System.Windows.Forms.ComboBox comboBoxDan;
        private System.Windows.Forms.TextBox textBoxMinut;
        private System.Windows.Forms.TextBox textBoxSat;
        private System.Windows.Forms.ComboBox comboBoxTrasaIzmeni;
        private System.Windows.Forms.Button buttonDodajvoznju;
        private System.Windows.Forms.Button buttonSacuvajOtkazaneVoznje;
        private System.Windows.Forms.TextBox textBoxMinutOtkazi;
        private System.Windows.Forms.TextBox textBoxSatOtkazi;
        private System.Windows.Forms.ComboBox comboBoxTrasaOtkazi;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.ComboBox comboBoxOtkazaneVoznje;
        private System.Windows.Forms.Button buttonIzbrisiRedVoznje;
        private System.Windows.Forms.Button buttonIzbrisiOtkazanaVoznja;
    }
}