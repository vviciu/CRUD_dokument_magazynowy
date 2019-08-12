namespace DokumentMagazynowy
{
    partial class Form_dokumentyMagazynowe
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_dokumentyMagazynowe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.button_edytuj = new System.Windows.Forms.Button();
            this.button_zamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dokumentyMagazynowe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_dokumentyMagazynowe
            // 
            this.dataGridView_dokumentyMagazynowe.AllowUserToAddRows = false;
            this.dataGridView_dokumentyMagazynowe.AllowUserToDeleteRows = false;
            this.dataGridView_dokumentyMagazynowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dokumentyMagazynowe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dokumentyMagazynowe.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_dokumentyMagazynowe.Name = "dataGridView_dokumentyMagazynowe";
            this.dataGridView_dokumentyMagazynowe.ReadOnly = true;
            this.dataGridView_dokumentyMagazynowe.Size = new System.Drawing.Size(1132, 646);
            this.dataGridView_dokumentyMagazynowe.TabIndex = 0;
            this.dataGridView_dokumentyMagazynowe.DataSourceChanged += new System.EventHandler(this.DataGridView_dokumentyMagazynowe_DataSourceChanged);
            this.dataGridView_dokumentyMagazynowe.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridView_dokumentyMagazynowe_ColumnAdded);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_zamknij);
            this.panel1.Controls.Add(this.button_edytuj);
            this.panel1.Controls.Add(this.button_usun);
            this.panel1.Controls.Add(this.button_dodaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 100);
            this.panel1.TabIndex = 1;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(40, 37);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 0;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.Button_dodaj_Click);
            // 
            // button_usun
            // 
            this.button_usun.Location = new System.Drawing.Point(202, 37);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(75, 23);
            this.button_usun.TabIndex = 1;
            this.button_usun.Text = "Usuń";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.Button_usun_Click);
            // 
            // button_edytuj
            // 
            this.button_edytuj.Location = new System.Drawing.Point(121, 37);
            this.button_edytuj.Name = "button_edytuj";
            this.button_edytuj.Size = new System.Drawing.Size(75, 23);
            this.button_edytuj.TabIndex = 2;
            this.button_edytuj.Text = "Edytuj";
            this.button_edytuj.UseVisualStyleBackColor = true;
            this.button_edytuj.Click += new System.EventHandler(this.Button_edytuj_Click);
            // 
            // button_zamknij
            // 
            this.button_zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zamknij.Location = new System.Drawing.Point(1011, 37);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(75, 23);
            this.button_zamknij.TabIndex = 3;
            this.button_zamknij.Text = "Zamknij";
            this.button_zamknij.UseVisualStyleBackColor = true;
            this.button_zamknij.Click += new System.EventHandler(this.Button_zamknij_Click);
            // 
            // Form_dokumentyMagazynowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_dokumentyMagazynowe);
            this.Name = "Form_dokumentyMagazynowe";
            this.Text = "Dokumenty magazynowe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dokumentyMagazynowe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dokumentyMagazynowe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_edytuj;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_zamknij;
    }
}

