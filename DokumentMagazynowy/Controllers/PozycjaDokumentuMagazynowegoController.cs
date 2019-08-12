using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DokumentMagazynowy.Model;

namespace DokumentMagazynowy.Controllers
{
    public class PozycjaDokumentuMagazynowegoController
    {
        private TaskDokMagEntities entity;
        public PozycjaDokumentuMagazynowegoController(TaskDokMagEntities entity)
        {
            this.entity = entity;
        }

        public PozycjaDokumentuMagazynowego ZwrocPozycjeDokumentuMagazynowego(int idPozycjiDokumentuMagazynowego)
        {
            var pozycjaDokumentuMagazynowego = (from pdm in entity.pozycja_dokumentu_magazynowego
                                                where pdm.id_pozycji_dokumentu_magazynowego == idPozycjiDokumentuMagazynowego
                                                select new PozycjaDokumentuMagazynowego()
                                                {
                                                    id_pozycji_dokumentu_magazynowego = pdm.id_pozycji_dokumentu_magazynowego,
                                                    nazwa_artykulu = pdm.nazwa_artykulu,
                                                    liczba = pdm.liczba,
                                                    cena_netto = pdm.cena_netto,
                                                    cena_brutto = pdm.cena_brutto,
                                                    id_dokumentu_magazynowego = pdm.id_dokumentu_magazynowego
                                                }).FirstOrDefault();
            return pozycjaDokumentuMagazynowego;
        }

        public void ZapiszPozycjeDokumentuMagazynowego(PozycjaDokumentuMagazynowego pozycjaDokumentuMagazynowego)
        {
            entity.pozycja_dokumentu_magazynowego.Add(new pozycja_dokumentu_magazynowego()
            {
                nazwa_artykulu = pozycjaDokumentuMagazynowego.nazwa_artykulu,
                liczba = pozycjaDokumentuMagazynowego.liczba,
                cena_netto = pozycjaDokumentuMagazynowego.cena_netto,
                cena_brutto = pozycjaDokumentuMagazynowego.cena_brutto,
                id_dokumentu_magazynowego = pozycjaDokumentuMagazynowego.id_dokumentu_magazynowego
            });

            entity.SaveChanges();
        }

        public void PoprawPozycjeDokumentuMagazynowego(PozycjaDokumentuMagazynowego pozycjaDokumentuMagazynowego)
        {
            var pozycjadokumentuMagazynowego2 = (from pdm in entity.pozycja_dokumentu_magazynowego
                                                 where pdm.id_pozycji_dokumentu_magazynowego == pozycjaDokumentuMagazynowego.id_pozycji_dokumentu_magazynowego
                                                 select pdm).FirstOrDefault();

            if (pozycjadokumentuMagazynowego2 != null)
            {
                pozycjadokumentuMagazynowego2.nazwa_artykulu = pozycjaDokumentuMagazynowego.nazwa_artykulu;
                pozycjadokumentuMagazynowego2.liczba = pozycjaDokumentuMagazynowego.liczba;
                pozycjadokumentuMagazynowego2.cena_netto = pozycjaDokumentuMagazynowego.cena_netto;
                pozycjadokumentuMagazynowego2.cena_brutto = pozycjaDokumentuMagazynowego.cena_brutto;
                entity.SaveChanges();
            }
        }
        public void UsunPozycjeDokumentuMagazynowego(int idPozycjiDokumentuMagazynowego)
        {
            var pozycjadokumentuMagazynowego2 = (from pdm in entity.pozycja_dokumentu_magazynowego
                                                 where pdm.id_pozycji_dokumentu_magazynowego == idPozycjiDokumentuMagazynowego
                                                 select pdm).FirstOrDefault();

            if (pozycjadokumentuMagazynowego2 != null)
            {
                entity.pozycja_dokumentu_magazynowego.Remove(pozycjadokumentuMagazynowego2);
                entity.SaveChanges();
            }
        }
    }
}
