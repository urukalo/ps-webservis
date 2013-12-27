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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPovratna = new System.Windows.Forms.CheckBox();
            this.comboBoxVrstaPopust = new System.Windows.Forms.ComboBox();
            this.ekartaKartaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxPopust = new System.Windows.Forms.CheckBox();
            this.comboBoxVremePolaska = new System.Windows.Forms.ComboBox();
            this.comboBoxDolaznaStanica = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatumPutovanja = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPolaznaStanica = new System.Windows.Forms.ComboBox();
            this.comboBoxTrasa = new System.Windows.Forms.ComboBox();
            this.ekartaKartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRezervisi = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource)).BeginInit();
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
            label4.Location = new System.Drawing.Point(341, 106);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPovratna);
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
            this.groupBox1.Size = new System.Drawing.Size(537, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o karti";
            // 
            // checkBoxPovratna
            // 
            this.checkBoxPovratna.AutoSize = true;
            this.checkBoxPovratna.Location = new System.Drawing.Point(344, 167);
            this.checkBoxPovratna.Name = "checkBoxPovratna";
            this.checkBoxPovratna.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPovratna.TabIndex = 12;
            this.checkBoxPovratna.Text = "Povratna";
            this.checkBoxPovratna.UseVisualStyleBackColor = true;
            // 
            // comboBoxVrstaPopust
            // 
            this.comboBoxVrstaPopust.DataSource = this.ekartaKartaBindingSource1;
            this.comboBoxVrstaPopust.FormattingEnabled = true;
            this.comboBoxVrstaPopust.Location = new System.Drawing.Point(118, 165);
            this.comboBoxVrstaPopust.Name = "comboBoxVrstaPopust";
            this.comboBoxVrstaPopust.Size = new System.Drawing.Size(194, 21);
            this.comboBoxVrstaPopust.TabIndex = 11;
            this.comboBoxVrstaPopust.Visible = false;
            // 
            // checkBoxPopust
            // 
            this.checkBoxPopust.AutoSize = true;
            this.checkBoxPopust.Enabled = false;
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
            this.comboBoxVremePolaska.Enabled = false;
            this.comboBoxVremePolaska.FormattingEnabled = true;
            this.comboBoxVremePolaska.Location = new System.Drawing.Point(387, 103);
            this.comboBoxVremePolaska.Name = "comboBoxVremePolaska";
            this.comboBoxVremePolaska.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVremePolaska.TabIndex = 9;
            // 
            // comboBoxDolaznaStanica
            // 
            this.comboBoxDolaznaStanica.Enabled = false;
            this.comboBoxDolaznaStanica.FormattingEnabled = true;
            this.comboBoxDolaznaStanica.Location = new System.Drawing.Point(118, 133);
            this.comboBoxDolaznaStanica.Name = "comboBoxDolaznaStanica";
            this.comboBoxDolaznaStanica.Size = new System.Drawing.Size(194, 21);
            this.comboBoxDolaznaStanica.TabIndex = 8;
            this.comboBoxDolaznaStanica.SelectedIndexChanged += new System.EventHandler(this.comboBoxDolaznaStanica_SelectedIndexChanged);
            // 
            // dateTimePickerDatumPutovanja
            // 
            this.dateTimePickerDatumPutovanja.CustomFormat = "d.M.yyyy";
            this.dateTimePickerDatumPutovanja.Enabled = false;
            this.dateTimePickerDatumPutovanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDatumPutovanja.Location = new System.Drawing.Point(118, 100);
            this.dateTimePickerDatumPutovanja.Name = "dateTimePickerDatumPutovanja";
            this.dateTimePickerDatumPutovanja.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDatumPutovanja.TabIndex = 4;
            this.dateTimePickerDatumPutovanja.ValueChanged += new System.EventHandler(this.dateTimePickerDatumPutovanja_ValueChanged);
            // 
            // comboBoxPolaznaStanica
            // 
            this.comboBoxPolaznaStanica.Enabled = false;
            this.comboBoxPolaznaStanica.FormattingEnabled = true;
            this.comboBoxPolaznaStanica.Location = new System.Drawing.Point(118, 63);
            this.comboBoxPolaznaStanica.Name = "comboBoxPolaznaStanica";
            this.comboBoxPolaznaStanica.Size = new System.Drawing.Size(194, 21);
            this.comboBoxPolaznaStanica.TabIndex = 3;
            this.comboBoxPolaznaStanica.SelectedIndexChanged += new System.EventHandler(this.comboBoxPolaznaStanica_SelectedIndexChanged);
            // 
            // comboBoxTrasa
            // 
            this.comboBoxTrasa.FormattingEnabled = true;
            this.comboBoxTrasa.Location = new System.Drawing.Point(118, 31);
            this.comboBoxTrasa.Name = "comboBoxTrasa";
            this.comboBoxTrasa.Size = new System.Drawing.Size(194, 21);
            this.comboBoxTrasa.TabIndex = 0;
            this.comboBoxTrasa.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrasa_SelectedIndexChanged);
            // 
            // buttonRezervisi
            // 
            this.buttonRezervisi.Location = new System.Drawing.Point(32, 283);
            this.buttonRezervisi.Name = "buttonRezervisi";
            this.buttonRezervisi.Size = new System.Drawing.Size(75, 23);
            this.buttonRezervisi.TabIndex = 2;
            this.buttonRezervisi.Text = "Rezerviši";
            this.buttonRezervisi.UseVisualStyleBackColor = true;
            this.buttonRezervisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Location = new System.Drawing.Point(150, 283);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(75, 23);
            this.buttonPonisti.TabIndex = 3;
            this.buttonPonisti.Text = "Poništi";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            this.buttonPonisti.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // administracijaToolStripMenuItem1
            // 
            this.administracijaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traseIStaniceToolStripMenuItem,
            this.redVoznjeToolStripMenuItem});
            this.administracijaToolStripMenuItem1.Name = "administracijaToolStripMenuItem1";
            this.administracijaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
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
            this.pronadjiKartuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pronadjiKartuToolStripMenuItem.Text = "Pronadji kartu";
            this.pronadjiKartuToolStripMenuItem.Click += new System.EventHandler(this.pronadjiKartuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 322);
            this.Controls.Add(this.buttonPonisti);
            this.Controls.Add(this.buttonRezervisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Kupovina karata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekartaKartaBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonRezervisi;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traseIStaniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redVoznjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronadjiKartuToolStripMenuItem;
        private System.Windows.Forms.BindingSource ekartaKartaBindingSource;
        private System.Windows.Forms.BindingSource ekartaKartaBindingSource1;
        private System.Windows.Forms.CheckBox checkBoxPovratna;
    }
}

