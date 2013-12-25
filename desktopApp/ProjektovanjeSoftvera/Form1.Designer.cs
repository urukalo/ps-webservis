namespace ProjektovanjeSoftvera
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVrstaPopust = new System.Windows.Forms.ComboBox();
            this.ekartaKartaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxPopust = new System.Windows.Forms.CheckBox();
            this.comboBoxVremePolaska = new System.Windows.Forms.ComboBox();
            this.comboBoxDolaznaStanica = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatumPutovanja = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPolaznaStanica = new System.Windows.Forms.ComboBox();
            this.comboBoxTrasa = new System.Windows.Forms.ComboBox();
            this.ekartaKartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPopust = new System.Windows.Forms.TextBox();
            this.textBoxKontaktTelefon = new System.Windows.Forms.TextBox();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.traseIStaniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redVoznjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronadjiKartuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 13);
            label1.TabIndex = 1;
            label1.Text = "Vozna trasa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 13);
            label2.TabIndex = 2;
            label2.Text = "Polazna stanica:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 13);
            label3.TabIndex = 5;
            label3.Text = "Datum putovanja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(324, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 6;
            label4.Text = "Vreme:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 136);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 13);
            label5.TabIndex = 7;
            label5.Text = "Dolazna stanica:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 29);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 13);
            label6.TabIndex = 2;
            label6.Text = "Ime i prezime:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(16, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 13);
            label8.TabIndex = 4;
            label8.Text = "Popust:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(16, 61);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(82, 13);
            label7.TabIndex = 5;
            label7.Text = "Kontakt telefon:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVrstaPopust);
            this.groupBox1.Controls.Add(this.checkBoxPopust);
            this.groupBox1.Controls.Add(this.comboBoxVremePolaska);
            this.groupBox1.Controls.Add(this.comboBoxDolaznaStanica);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.dateTimePickerDatumPutovanja);
            this.groupBox1.Controls.Add(this.comboBoxPolaznaStanica);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.comboBoxTrasa);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o karti";
            // 
            // comboBoxVrstaPopust
            // 
            this.comboBoxVrstaPopust.DataSource = this.ekartaKartaBindingSource1;
            this.comboBoxVrstaPopust.FormattingEnabled = true;
            this.comboBoxVrstaPopust.Location = new System.Drawing.Point(118, 165);
            this.comboBoxVrstaPopust.Name = "comboBoxVrstaPopust";
            this.comboBoxVrstaPopust.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVrstaPopust.TabIndex = 11;
            this.comboBoxVrstaPopust.Visible = false;
            // 
            // checkBoxPopust
            // 
            this.checkBoxPopust.AutoSize = true;
            this.checkBoxPopust.Location = new System.Drawing.Point(19, 169);
            this.checkBoxPopust.Name = "checkBoxPopust";
            this.checkBoxPopust.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPopust.TabIndex = 10;
            this.checkBoxPopust.Text = "Popust";
            this.checkBoxPopust.UseVisualStyleBackColor = true;
            this.checkBoxPopust.CheckedChanged += new System.EventHandler(this.checkBoxPopust_CheckedChanged);
            // 
            // comboBoxVremePolaska
            // 
            this.comboBoxVremePolaska.FormattingEnabled = true;
            this.comboBoxVremePolaska.Location = new System.Drawing.Point(370, 103);
            this.comboBoxVremePolaska.Name = "comboBoxVremePolaska";
            this.comboBoxVremePolaska.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVremePolaska.TabIndex = 9;
            // 
            // comboBoxDolaznaStanica
            // 
            this.comboBoxDolaznaStanica.FormattingEnabled = true;
            this.comboBoxDolaznaStanica.Location = new System.Drawing.Point(118, 133);
            this.comboBoxDolaznaStanica.Name = "comboBoxDolaznaStanica";
            this.comboBoxDolaznaStanica.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDolaznaStanica.TabIndex = 8;
            // 
            // dateTimePickerDatumPutovanja
            // 
            this.dateTimePickerDatumPutovanja.CustomFormat = "d.M.yyyy";
            this.dateTimePickerDatumPutovanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDatumPutovanja.Location = new System.Drawing.Point(118, 100);
            this.dateTimePickerDatumPutovanja.Name = "dateTimePickerDatumPutovanja";
            this.dateTimePickerDatumPutovanja.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDatumPutovanja.TabIndex = 4;
            // 
            // comboBoxPolaznaStanica
            // 
            this.comboBoxPolaznaStanica.FormattingEnabled = true;
            this.comboBoxPolaznaStanica.Location = new System.Drawing.Point(118, 63);
            this.comboBoxPolaznaStanica.Name = "comboBoxPolaznaStanica";
            this.comboBoxPolaznaStanica.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPolaznaStanica.TabIndex = 3;
            // 
            // comboBoxTrasa
            // 
            this.comboBoxTrasa.FormattingEnabled = true;
            this.comboBoxTrasa.Location = new System.Drawing.Point(118, 31);
            this.comboBoxTrasa.Name = "comboBoxTrasa";
            this.comboBoxTrasa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrasa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPopust);
            this.groupBox2.Controls.Add(this.textBoxKontaktTelefon);
            this.groupBox2.Controls.Add(this.textBoxImePrezime);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usluge o korisniku";
            // 
            // textBoxPopust
            // 
            this.textBoxPopust.Location = new System.Drawing.Point(118, 92);
            this.textBoxPopust.Name = "textBoxPopust";
            this.textBoxPopust.Size = new System.Drawing.Size(172, 20);
            this.textBoxPopust.TabIndex = 8;
            // 
            // textBoxKontaktTelefon
            // 
            this.textBoxKontaktTelefon.Location = new System.Drawing.Point(118, 58);
            this.textBoxKontaktTelefon.Name = "textBoxKontaktTelefon";
            this.textBoxKontaktTelefon.Size = new System.Drawing.Size(172, 20);
            this.textBoxKontaktTelefon.TabIndex = 7;
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(118, 22);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(172, 20);
            this.textBoxImePrezime.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rezerviši";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Poništi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.administracijaToolStripMenuItem1,
            this.pronadjiKartuToolStripMenuItem});
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // administracijaToolStripMenuItem1
            // 
            this.administracijaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traseIStaniceToolStripMenuItem,
            this.redVoznjeToolStripMenuItem});
            this.administracijaToolStripMenuItem1.Name = "administracijaToolStripMenuItem1";
            this.administracijaToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.administracijaToolStripMenuItem1.Text = "Administracija";
            this.administracijaToolStripMenuItem1.Click += new System.EventHandler(this.administracijaToolStripMenuItem1_Click);
            // 
            // traseIStaniceToolStripMenuItem
            // 
            this.traseIStaniceToolStripMenuItem.Name = "traseIStaniceToolStripMenuItem";
            this.traseIStaniceToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.traseIStaniceToolStripMenuItem.Text = "Trase i stanice";
            this.traseIStaniceToolStripMenuItem.Click += new System.EventHandler(this.traseIStaniceToolStripMenuItem_Click);
            // 
            // redVoznjeToolStripMenuItem
            // 
            this.redVoznjeToolStripMenuItem.Name = "redVoznjeToolStripMenuItem";
            this.redVoznjeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.redVoznjeToolStripMenuItem.Text = "Red voznje";
            this.redVoznjeToolStripMenuItem.Click += new System.EventHandler(this.redVoznjeToolStripMenuItem_Click);
            // 
            // pronadjiKartuToolStripMenuItem
            // 
            this.pronadjiKartuToolStripMenuItem.Name = "pronadjiKartuToolStripMenuItem";
            this.pronadjiKartuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pronadjiKartuToolStripMenuItem.Text = "Pronadji kartu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Kupovina karata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxVrstaPopust;
        private System.Windows.Forms.CheckBox checkBoxPopust;
        private System.Windows.Forms.ComboBox comboBoxVremePolaska;
        private System.Windows.Forms.ComboBox comboBoxDolaznaStanica;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPutovanja;
        private System.Windows.Forms.ComboBox comboBoxPolaznaStanica;
        private System.Windows.Forms.ComboBox comboBoxTrasa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPopust;
        private System.Windows.Forms.TextBox textBoxKontaktTelefon;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traseIStaniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redVoznjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronadjiKartuToolStripMenuItem;
        private System.Windows.Forms.BindingSource ekartaKartaBindingSource;
        private System.Windows.Forms.BindingSource ekartaKartaBindingSource1;
    }
}

