//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lagerprogramm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ersatzteile
    {
        public string Artikelbezeichnung { get; set; }
        public string Artikelnummer { get; set; }
        public string Lagerplatz { get; set; }
        public int Anzahl { get; set; }
        public string Baugruppennummer { get; set; }
        public string Maschinenummer { get; set; }
    
        public virtual Baugruppen Baugruppen { get; set; }
        public virtual Maschinen Maschinen { get; set; }
    }
}
