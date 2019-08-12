namespace DokumentMagazynowy.View
{
    partial class Form_pozycjaDokumentuMagazynowego
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
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nazwaArtykulu = new System.Windows.Forms.TextBox();
            this.numericUpDown_liczba = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_cenaNetto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_cenaBrutto = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_liczba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaNetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaBrutto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_zapisz);
            this.panel1.Controls.Add(this.button_anuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 86);
            this.panel1.TabIndex = 0;
            // 
            // button_anuluj
            // 
            this.button_anuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_anuluj.Location = new System.Drawing.Point(497, 29);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 23);
            this.button_anuluj.TabIndex = 0;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.Button_anuluj_Click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zapisz.Location = new System.Drawing.Point(416, 29);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(75, 23);
            this.button_zapisz.TabIndex = 1;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.Button_zapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa artykułu:";
            // 
            // textBox_nazwaArtykulu
            // 
            this.textBox_nazwaArtykulu.Location = new System.Drawing.Point(219, 48);
            this.textBox_nazwaArtykulu.Name = "textBox_nazwaArtykulu";
            this.textBox_nazwaArtykulu.Size = new System.Drawing.Size(293, 20);
            this.textBox_nazwaArtykulu.TabIndex = 2;
            // 
            // numericUpDown_liczba
            // 
            this.numericUpDown_liczba.Location = new System.Drawing.Point(219, 74);
            this.numericUpDown_liczba.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_liczba.Name = "numericUpDown_liczba";
            this.numericUpDown_liczba.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_liczba.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena netto:";
            // 
            // numericUpDown_cenaNetto
            // 
            this.numericUpDown_cenaNetto.DecimalPlaces = 2;
            this.numericUpDown_cenaNetto.Location = new System.Drawing.Point(219, 100);
            this.numericUpDown_cenaNetto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_cenaNetto.Name = "numericUpDown_cenaNetto";
            this.numericUpDown_cenaNetto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cenaNetto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena brutto:";
            // 
            // numericUpDown_cenaBrutto
            // 
            this.numericUpDown_cenaBrutto.DecimalPlaces = 2;
            this.numericUpDown_cenaBrutto.Location = new System.Drawing.Point(219, 126);
            this.numericUpDown_cenaBrutto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_cenaBrutto.Name = "numericUpDown_cenaBrutto";
            this.numericUpDown_cenaBrutto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cenaBrutto.TabIndex = 7;
            // 
            // Form_pozycjaDokumentuMagazynowego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_cenaBrutto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_cenaNetto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_liczba);
            this.Controls.Add(this.textBox_nazwaArtykulu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_pozycjaDokumentuMagazynowego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pozycja dokumentu magazynowego";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_liczba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaNetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cenaBrutto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nazwaArtykulu;
        private System.Windows.Forms.NumericUpDown numericUpDown_liczba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_cenaNetto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_cenaBrutto;
    }
}