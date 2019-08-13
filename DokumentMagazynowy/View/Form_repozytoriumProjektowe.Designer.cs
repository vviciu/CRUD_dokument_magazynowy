namespace DokumentMagazynowy.View
{
    partial class Form_repozytoriumProjektowe
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
            this.button_zamknij = new System.Windows.Forms.Button();
            this.richTextBox_infoRepozytorium = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_zamknij);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 84);
            this.panel1.TabIndex = 0;
            // 
            // button_zamknij
            // 
            this.button_zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zamknij.Location = new System.Drawing.Point(592, 28);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(75, 23);
            this.button_zamknij.TabIndex = 0;
            this.button_zamknij.Text = "Zamknij";
            this.button_zamknij.UseVisualStyleBackColor = true;
            this.button_zamknij.Click += new System.EventHandler(this.Button_zamknij_Click);
            // 
            // richTextBox_infoRepozytorium
            // 
            this.richTextBox_infoRepozytorium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_infoRepozytorium.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_infoRepozytorium.Name = "richTextBox_infoRepozytorium";
            this.richTextBox_infoRepozytorium.Size = new System.Drawing.Size(710, 366);
            this.richTextBox_infoRepozytorium.TabIndex = 1;
            this.richTextBox_infoRepozytorium.Text = "";
            // 
            // Form_repozytoriumProjektowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.richTextBox_infoRepozytorium);
            this.Controls.Add(this.panel1);
            this.Name = "Form_repozytoriumProjektowe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inforamcje - repozytorium";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_infoRepozytorium;
        private System.Windows.Forms.Button button_zamknij;
    }
}