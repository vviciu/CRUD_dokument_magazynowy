namespace DokumentMagazynowy.View
{
    partial class Form_dokumentMagazynowy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_cenaBrutto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_cenaNetto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nazwa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_numerKlienta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_zamknij = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.button_edytuj = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.dataGridView_pozycjeDokumentuMagazynowego = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaBrutto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaNetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numerKlienta)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pozycjeDokumentuMagazynowego)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown_cenaBrutto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown_cenaNetto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_nazwa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDown_numerKlienta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker_data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 99);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown_cenaBrutto
            // 
            this.numericUpDown_cenaBrutto.DecimalPlaces = 2;
            this.numericUpDown_cenaBrutto.Enabled = false;
            this.numericUpDown_cenaBrutto.Location = new System.Drawing.Point(302, 64);
            this.numericUpDown_cenaBrutto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_cenaBrutto.Name = "numericUpDown_cenaBrutto";
            this.numericUpDown_cenaBrutto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cenaBrutto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cena brutto:";
            // 
            // numericUpDown_cenaNetto
            // 
            this.numericUpDown_cenaNetto.DecimalPlaces = 2;
            this.numericUpDown_cenaNetto.Enabled = false;
            this.numericUpDown_cenaNetto.Location = new System.Drawing.Point(105, 64);
            this.numericUpDown_cenaNetto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_cenaNetto.Name = "numericUpDown_cenaNetto";
            this.numericUpDown_cenaNetto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cenaNetto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena netto:";
            // 
            // textBox_nazwa
            // 
            this.textBox_nazwa.Location = new System.Drawing.Point(302, 37);
            this.textBox_nazwa.Name = "textBox_nazwa";
            this.textBox_nazwa.Size = new System.Drawing.Size(299, 20);
            this.textBox_nazwa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwa:";
            // 
            // numericUpDown_numerKlienta
            // 
            this.numericUpDown_numerKlienta.Location = new System.Drawing.Point(105, 38);
            this.numericUpDown_numerKlienta.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_numerKlienta.Name = "numericUpDown_numerKlienta";
            this.numericUpDown_numerKlienta.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_numerKlienta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numer klienta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data.Location = new System.Drawing.Point(105, 12);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_data.TabIndex = 0;
            this.dateTimePicker_data.Value = new System.DateTime(2019, 8, 12, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_zamknij);
            this.panel2.Controls.Add(this.button_usun);
            this.panel2.Controls.Add(this.button_edytuj);
            this.panel2.Controls.Add(this.button_dodaj);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 76);
            this.panel2.TabIndex = 1;
            // 
            // button_zamknij
            // 
            this.button_zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zamknij.Location = new System.Drawing.Point(856, 26);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(75, 23);
            this.button_zamknij.TabIndex = 3;
            this.button_zamknij.Text = "Zamknij";
            this.button_zamknij.UseVisualStyleBackColor = true;
            this.button_zamknij.Click += new System.EventHandler(this.Button_zamknij_Click);
            // 
            // button_usun
            // 
            this.button_usun.Location = new System.Drawing.Point(202, 26);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(75, 23);
            this.button_usun.TabIndex = 2;
            this.button_usun.Text = "Usuń";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.Button_usun_Click);
            // 
            // button_edytuj
            // 
            this.button_edytuj.Location = new System.Drawing.Point(121, 26);
            this.button_edytuj.Name = "button_edytuj";
            this.button_edytuj.Size = new System.Drawing.Size(75, 23);
            this.button_edytuj.TabIndex = 1;
            this.button_edytuj.Text = "Edytuj";
            this.button_edytuj.UseVisualStyleBackColor = true;
            this.button_edytuj.Click += new System.EventHandler(this.Button_edytuj_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(40, 26);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 0;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.Button_dodaj_Click);
            // 
            // dataGridView_pozycjeDokumentuMagazynowego
            // 
            this.dataGridView_pozycjeDokumentuMagazynowego.AllowUserToAddRows = false;
            this.dataGridView_pozycjeDokumentuMagazynowego.AllowUserToDeleteRows = false;
            this.dataGridView_pozycjeDokumentuMagazynowego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pozycjeDokumentuMagazynowego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_pozycjeDokumentuMagazynowego.Location = new System.Drawing.Point(0, 99);
            this.dataGridView_pozycjeDokumentuMagazynowego.Name = "dataGridView_pozycjeDokumentuMagazynowego";
            this.dataGridView_pozycjeDokumentuMagazynowego.ReadOnly = true;
            this.dataGridView_pozycjeDokumentuMagazynowego.Size = new System.Drawing.Size(964, 362);
            this.dataGridView_pozycjeDokumentuMagazynowego.TabIndex = 2;
            this.dataGridView_pozycjeDokumentuMagazynowego.DataSourceChanged += new System.EventHandler(this.DataGridView_pozycjeDokumentuMagazynowego_DataSourceChanged);
            this.dataGridView_pozycjeDokumentuMagazynowego.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridView_pozycjeDokumentuMagazynowego_ColumnAdded);
            // 
            // Form_dokumentMagazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 537);
            this.Controls.Add(this.dataGridView_pozycjeDokumentuMagazynowego);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_dokumentMagazynowy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dokument magazynowy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaBrutto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaNetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numerKlienta)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pozycjeDokumentuMagazynowego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_pozycjeDokumentuMagazynowego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.NumericUpDown numericUpDown_numerKlienta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nazwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_cenaNetto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_cenaBrutto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_edytuj;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_zamknij;
    }
}