using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentMagazynowy.Model
{
    public class DokumentMagazynowy
    {
        public int id_dokumentu_magazynowego { get; set; }
        public System.DateTime data { get; set; }
        public int numer_klienta { get; set; }
        public string nazwa { get; set; }
        public Nullable<decimal> cena_netto { get; set; }
        public Nullable<decimal> cena_brutto { get; set; }
    }
}
