//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DokumentMagazynowy.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class pozycja_dokumentu_magazynowego
    {
        public int id_pozycji_dokumentu_magazynowego { get; set; }
        public string nazwa_artykulu { get; set; }
        public int liczba { get; set; }
        public decimal cena_netto { get; set; }
        public decimal cena_brutto { get; set; }
        public int id_dokumentu_magazynowego { get; set; }
    
        public virtual dokument_magazynowy dokument_magazynowy { get; set; }
    }
}