using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DokumentMagazynowy.Model;

namespace DokumentMagazynowy.Controllers
{
    class DokumentMagazynowyController
    {
        private TaskDokMagEntities entity;
        public DokumentMagazynowyController(TaskDokMagEntities entity)
        {
            this.entity = entity;
        }

        public dokument_magazynowy pobierzDokumentMagazynowy(int id_dokumentu_magazynowego)
        {
            var dokMagazynowy = (from dm in entity.dokument_magazynowy
                                 where dm.id_dokumentu_magazynowego == id_dokumentu_magazynowego
                                 select dm).FirstOrDefault();
            return dokMagazynowy;
        }

        public List<DokumentMagazynowy.Model.DokumentMagazynowy> pobierzDokumentyMagazynowe()
        {
            var dokMagazynowe = (from dm in entity.dokument_magazynowy
                                 orderby dm.data, dm.numer_klienta ascending
                                 select new DokumentMagazynowy.Model.DokumentMagazynowy() {
                                     id_dokumentu_magazynowego = dm.id_dokumentu_magazynowego,
                                     data = dm.data,
                                     numer_klienta = dm.numer_klienta,
                                     nazwa = dm.nazwa,
                                     cena_netto = dm.cena_netto,
                                     cena_brutto = dm.cena_brutto
                                 }).ToList();
            return dokMagazynowe;
        }

        public int ZapiszDokumentMagazynowy(DokumentMagazynowy.Model.DokumentMagazynowy dokumentMagazynowy)
        {
            dokument_magazynowy dokMag = new dokument_magazynowy()
            {
                data = dokumentMagazynowy.data,
                numer_klienta = dokumentMagazynowy.numer_klienta,
                nazwa = dokumentMagazynowy.nazwa
            };
            entity.dokument_magazynowy.Add(dokMag);

            entity.SaveChanges();

            return dokMag.id_dokumentu_magazynowego;
        }

        public void PoprawDokumentMagazynowy(DokumentMagazynowy.Model.DokumentMagazynowy dokumentMagazynowy)
        {
            var dokumentMagazynowy2 = (from dm in entity.dokument_magazynowy
                                       where dm.id_dokumentu_magazynowego == dokumentMagazynowy.id_dokumentu_magazynowego
                                       select dm).FirstOrDefault();

            if (dokumentMagazynowy2 != null)
            {
                dokumentMagazynowy2.numer_klienta = dokumentMagazynowy.numer_klienta;
                dokumentMagazynowy2.nazwa = dokumentMagazynowy.nazwa;
                dokumentMagazynowy2.data = dokumentMagazynowy.data;

                entity.SaveChanges();
            }
        }

        public void UsunDokumentMagazynowy(int idDokumentuMagazynowego)
        {
            var dokumentMagazynowy2 = (from dm in entity.dokument_magazynowy
                                       where dm.id_dokumentu_magazynowego == idDokumentuMagazynowego
                                       select dm).FirstOrDefault();

            if (dokumentMagazynowy2 != null)
            {
                entity.dokument_magazynowy.Remove(dokumentMagazynowy2);
                entity.SaveChanges();
            }
        }
    }
}
