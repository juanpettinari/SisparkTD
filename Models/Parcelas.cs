//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisParkTD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcelas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parcelas()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int IDParcela { get; set; }
        public int NumeroParcela { get; set; }
        public bool Disponible { get; set; }
        public int IDTamaño { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
        public virtual Tamaños Tamaños { get; set; }
    }
}
