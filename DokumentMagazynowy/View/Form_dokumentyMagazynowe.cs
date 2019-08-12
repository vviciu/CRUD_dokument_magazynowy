using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DokumentMagazynowy.Model;
using DokumentMagazynowy.Controllers;
using DokumentMagazynowy.View;

namespace DokumentMagazynowy
{
    public partial class Form_dokumentyMagazynowe : Form
    {
        public Form_dokumentyMagazynowe()
        {
            InitializeComponent();
            ZaladujDokumentyMagazynowe();
        }

        private void ZaladujDokumentyMagazynowe()
        {
            using(var entity = new TaskDokMagEntities())
            {
                var dokMagazynoweController = new DokumentMagazynowyController(entity);
                var dokumentyMagazynowe = dokMagazynoweController.pobierzDokumentyMagazynowe();
                dataGridView_dokumentyMagazynowe.DataSource = null;
                dataGridView_dokumentyMagazynowe.DataSource = dokumentyMagazynowe;
                if (dokumentyMagazynowe.Count() > 0)
                {
                    button_usun.Enabled = button_edytuj.Enabled = true;
                }
                else
                {
                    button_usun.Enabled = button_edytuj.Enabled = false;
                }
            }
        }

        private void DataGridView_dokumentyMagazynowe_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView_dokumentyMagazynowe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_dokumentyMagazynowe.MultiSelect = false;
            dataGridView_dokumentyMagazynowe.AutoResizeColumns();
            dataGridView_dokumentyMagazynowe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataGridView_dokumentyMagazynowe_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "id_dokumentu_magazynowego":
                    e.Column.Visible = false;
                    break;
                default:
                    e.Column.Visible = true;
                    break;
            }
        }

        private void Button_zamknij_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz wyjść z programu?","Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Button_dodaj_Click(object sender, EventArgs e)
        {
            Form_dokumentMagazynowy dokMag_form = new Form_dokumentMagazynowy(null);
            dokMag_form.ShowDialog();
            ZaladujDokumentyMagazynowe();
        }

        private void Button_edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView_dokumentyMagazynowe.SelectedRows.Count != 0)
            {
                int idDokumentuMagazynowego = int.Parse(dataGridView_dokumentyMagazynowe["id_dokumentu_magazynowego", dataGridView_dokumentyMagazynowe.SelectedRows[0].Index].Value.ToString());
                Form_dokumentMagazynowy dokMag_form = new Form_dokumentMagazynowy(idDokumentuMagazynowego);
                dokMag_form.ShowDialog();
                ZaladujDokumentyMagazynowe();
            }
        }

        private void Button_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView_dokumentyMagazynowe.SelectedRows.Count != 0)
            {
                int idDokumentuMagazynowego = int.Parse(dataGridView_dokumentyMagazynowe["id_dokumentu_magazynowego", dataGridView_dokumentyMagazynowe.SelectedRows[0].Index].Value.ToString());
                if(MessageBox.Show("Jesteś pewien?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var entity = new TaskDokMagEntities())
                    {
                        var dokumentMagazynowyController = new DokumentMagazynowyController(entity);
                        dokumentMagazynowyController.UsunDokumentMagazynowy(idDokumentuMagazynowego);
                    }
                    ZaladujDokumentyMagazynowe();
                }
            }
        }
    }
}
