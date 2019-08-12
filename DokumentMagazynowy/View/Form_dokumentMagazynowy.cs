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

namespace DokumentMagazynowy.View
{
    public partial class Form_dokumentMagazynowy : Form
    {
        private int? id_dokumentu_magazynowego;

        public Form_dokumentMagazynowy(int? id_dokumentu_magazynowego)
        {
            InitializeComponent();
            this.id_dokumentu_magazynowego = id_dokumentu_magazynowego;
            ZaladujDaneNaFormularz();
        }

        private void ZaladujDaneNaFormularz()
        {
            if (id_dokumentu_magazynowego != null)
            {
                using (var entity = new TaskDokMagEntities())
                {
                    var dokMagController = new DokumentMagazynowy.Controllers.DokumentMagazynowyController(entity);
                    var dokMag = dokMagController.pobierzDokumentMagazynowy(id_dokumentu_magazynowego??0);

                    var dokMagModel = new DokumentMagazynowy.Model.DokumentMagazynowy()
                    {
                        id_dokumentu_magazynowego = dokMag.id_dokumentu_magazynowego,
                        data = dokMag.data,
                        numer_klienta = dokMag.numer_klienta,
                        nazwa = dokMag.nazwa,
                        cena_netto = dokMag.cena_netto,
                        cena_brutto = dokMag.cena_brutto
                    };

                    dateTimePicker_data.Value = dokMagModel.data;
                    numericUpDown_numerKlienta.Value = dokMagModel.numer_klienta;
                    textBox_nazwa.Text = dokMagModel.nazwa;
                    numericUpDown_cenaNetto.Value = dokMagModel.cena_netto??0;
                    numericUpDown_cenaBrutto.Value = dokMagModel.cena_brutto??0;

                    var listaPozycjiDokumentuMagazynowego = dokMag.pozycja_dokumentu_magazynowego.ToList();
                    dataGridView_pozycjeDokumentuMagazynowego.DataSource = listaPozycjiDokumentuMagazynowego;

                    button_dodaj.Enabled = true;
                    if (listaPozycjiDokumentuMagazynowego.Count() > 0)
                    {
                        button_edytuj.Enabled = true;
                        button_usun.Enabled = true;
                    }
                    else
                    {
                        button_edytuj.Enabled = false;
                        button_usun.Enabled = false;
                    }
                }
            }
            else
            {
                dateTimePicker_data.Value = DateTime.Now.Date;
                button_dodaj.Enabled = true;
                button_edytuj.Enabled = false;
                button_usun.Enabled = false;
            }
        }

        private void Button_zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_dodaj_Click(object sender, EventArgs e)
        {
            if (id_dokumentu_magazynowego == null)
            {
                if (numericUpDown_numerKlienta.Value == 0) { MessageBox.Show("Wprowadź numer klienta.","Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (string.IsNullOrEmpty(textBox_nazwa.Text)) { MessageBox.Show("Wprowadź nazwę kontrahenta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                var dokumentMagazynowy = new DokumentMagazynowy.Model.DokumentMagazynowy() {
                    data = dateTimePicker_data.Value.Date,
                    numer_klienta = (int)numericUpDown_numerKlienta.Value,
                    nazwa = textBox_nazwa.Text
                };

                using (var entity = new TaskDokMagEntities())
                {
                    var dokumentMagazynowyController = new DokumentMagazynowyController(entity);
                    id_dokumentu_magazynowego = dokumentMagazynowyController.ZapiszDokumentMagazynowy(dokumentMagazynowy);
                }
            }

            var pozycjaDokumentuMagazynowego_form = new Form_pozycjaDokumentuMagazynowego(id_dokumentu_magazynowego ?? 0, null);
            if (pozycjaDokumentuMagazynowego_form.ShowDialog() == DialogResult.Yes)
            {
                ZaladujDaneNaFormularz();
            }
        }

        private void DataGridView_pozycjeDokumentuMagazynowego_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "id_pozycji_dokumentu_magazynowego":
                    e.Column.Visible = false;
                    break;
                case "id_dokumentu_magazynowego":
                    e.Column.Visible = false;
                    break;
                case "dokument_magazynowy":
                    e.Column.Visible = false;
                    break; 
                default:
                    e.Column.Visible = true;
                    break;
            }
        }

        private void DataGridView_pozycjeDokumentuMagazynowego_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView_pozycjeDokumentuMagazynowego.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_pozycjeDokumentuMagazynowego.MultiSelect = false;
            dataGridView_pozycjeDokumentuMagazynowego.AutoResizeColumns();
            dataGridView_pozycjeDokumentuMagazynowego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Button_edytuj_Click(object sender, EventArgs e)
        {
            if (id_dokumentu_magazynowego != null)
            {
                if (numericUpDown_numerKlienta.Value == 0) { MessageBox.Show("Wprowadź numer klienta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (string.IsNullOrEmpty(textBox_nazwa.Text)) { MessageBox.Show("Wprowadź nazwę kontrahenta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                var dokumentMagazynowy = new DokumentMagazynowy.Model.DokumentMagazynowy()
                {
                    data = dateTimePicker_data.Value.Date,
                    numer_klienta = (int)numericUpDown_numerKlienta.Value,
                    nazwa = textBox_nazwa.Text,
                    id_dokumentu_magazynowego = id_dokumentu_magazynowego ?? 0
                };

                using (var entity = new TaskDokMagEntities())
                {
                    var dokumentMagazynowyController = new DokumentMagazynowyController(entity);
                    dokumentMagazynowyController.PoprawDokumentMagazynowy(dokumentMagazynowy);
                }
            }


            if (dataGridView_pozycjeDokumentuMagazynowego.SelectedRows.Count != 0)
            {
                int idPozycjiDokumentuMagazynowego = int.Parse(dataGridView_pozycjeDokumentuMagazynowego["id_pozycji_dokumentu_magazynowego", dataGridView_pozycjeDokumentuMagazynowego.SelectedRows[0].Index].Value.ToString());

                var pozycjaDokumentuMagazynowego_form = new Form_pozycjaDokumentuMagazynowego(id_dokumentu_magazynowego ?? 0, idPozycjiDokumentuMagazynowego);
                if (pozycjaDokumentuMagazynowego_form.ShowDialog() == DialogResult.Yes)
                {
                    ZaladujDaneNaFormularz();
                }
            }
        }

        private void Button_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView_pozycjeDokumentuMagazynowego.SelectedRows.Count != 0)
            {
                int idPozycjiDokumentuMagazynowego = int.Parse(dataGridView_pozycjeDokumentuMagazynowego["id_pozycji_dokumentu_magazynowego", dataGridView_pozycjeDokumentuMagazynowego.SelectedRows[0].Index].Value.ToString());
                if (MessageBox.Show("Jesteś pewien?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var entity = new TaskDokMagEntities())
                    {
                        var pozycjaDokumentuMagazynowegoController = new PozycjaDokumentuMagazynowegoController(entity);
                        pozycjaDokumentuMagazynowegoController.UsunPozycjeDokumentuMagazynowego(idPozycjiDokumentuMagazynowego);
                    }
                    ZaladujDaneNaFormularz();
                }
            }
        }
    }
}
