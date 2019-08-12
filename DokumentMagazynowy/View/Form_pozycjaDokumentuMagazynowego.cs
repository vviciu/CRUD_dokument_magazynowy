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
    public partial class Form_pozycjaDokumentuMagazynowego : Form
    {
        private int? id_pozycji_dokumentu_magazynowego;
        private int id_dokumentu_magazynowego;

        public Form_pozycjaDokumentuMagazynowego(int id_dokumentu_magazynowego, int? id_pozycji_dokumentu_magazynowego)
        {
            InitializeComponent();
            this.id_dokumentu_magazynowego = id_dokumentu_magazynowego;
            this.id_pozycji_dokumentu_magazynowego = id_pozycji_dokumentu_magazynowego;
            ZaladujDaneNaFormularz();
        }

        private void ZaladujDaneNaFormularz()
        {
            if (id_pozycji_dokumentu_magazynowego != null)
            {
                using (var entity = new TaskDokMagEntities())
                {
                    var pozycjaDokumentuMagazynowegoController = new PozycjaDokumentuMagazynowegoController(entity);
                    var pozycjaDokumentuMagazynowego = pozycjaDokumentuMagazynowegoController.ZwrocPozycjeDokumentuMagazynowego(id_pozycji_dokumentu_magazynowego??0);
                    if (pozycjaDokumentuMagazynowego != null)
                    {
                        textBox_nazwaArtykulu.Text = pozycjaDokumentuMagazynowego.nazwa_artykulu;
                        numericUpDown_liczba.Value = pozycjaDokumentuMagazynowego.liczba;
                        numericUpDown_cenaNetto.Value = pozycjaDokumentuMagazynowego.cena_netto;
                        numericUpDown_cenaBrutto.Value = pozycjaDokumentuMagazynowego.cena_brutto;
                    }
                }
            }
        }

        private void Button_anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_zapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nazwaArtykulu.Text)) { MessageBox.Show("Wprowadź nazwę artykułu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (numericUpDown_liczba.Value == 0) { MessageBox.Show("Wprowadź liczbę.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (numericUpDown_cenaNetto.Value == 0) { MessageBox.Show("Wprowadź cenę netto.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (numericUpDown_cenaBrutto.Value == 0) { MessageBox.Show("Wprowadź cenę brutto.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (id_pozycji_dokumentu_magazynowego == null)
            {
                var pozycjaDokumentuMagazynowego = new PozycjaDokumentuMagazynowego() {
                    id_dokumentu_magazynowego = id_dokumentu_magazynowego,
                    nazwa_artykulu = textBox_nazwaArtykulu.Text,
                    liczba = (int)numericUpDown_liczba.Value,
                    cena_netto = numericUpDown_cenaNetto.Value,
                    cena_brutto = numericUpDown_cenaBrutto.Value
                };

                using (var entity = new TaskDokMagEntities())
                {
                    var pozycjaDokumentuMagazynowegoController = new PozycjaDokumentuMagazynowegoController(entity);
                    pozycjaDokumentuMagazynowegoController.ZapiszPozycjeDokumentuMagazynowego(pozycjaDokumentuMagazynowego);
                }
            }
            else
            {
                var pozycjaDokumentuMagazynowego = new PozycjaDokumentuMagazynowego()
                {
                    id_pozycji_dokumentu_magazynowego = id_pozycji_dokumentu_magazynowego??0,
                    id_dokumentu_magazynowego = id_dokumentu_magazynowego,
                    nazwa_artykulu = textBox_nazwaArtykulu.Text,
                    liczba = (int)numericUpDown_liczba.Value,
                    cena_netto = numericUpDown_cenaNetto.Value,
                    cena_brutto = numericUpDown_cenaBrutto.Value
                };

                using (var entity = new TaskDokMagEntities())
                {
                    var pozycjaDokumentuMagazynowegoController = new PozycjaDokumentuMagazynowegoController(entity);
                    pozycjaDokumentuMagazynowegoController.PoprawPozycjeDokumentuMagazynowego(pozycjaDokumentuMagazynowego);
                }
            }
            this.DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
