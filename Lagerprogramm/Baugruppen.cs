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
    
    public partial class Baugruppen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Baugruppen()
        {
            this.Ersatzteile = new HashSet<Ersatzteile>();
        }
    
        public string Baugruppe { get; set; }
        public string Baugruppennummer { get; set; }
        public string Maschine { get; set; }
        public string Hersteller { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ersatzteile> Ersatzteile { get; set; }
    }
}