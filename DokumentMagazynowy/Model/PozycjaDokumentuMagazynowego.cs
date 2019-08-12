using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentMagazynowy.Model
{
    public class PozycjaDokumentuMagazynowego
    {
        public int id_pozycji_dokumentu_magazynowego { get; set; }
        public string nazwa_artykulu { get; set; }
        public int liczba { get; set; }
        public decimal cena_netto { get; set; }
        public decimal cena_brutto { get; set; }
        public int id_dokumentu_magazynowego { get; set; }
    }
}
