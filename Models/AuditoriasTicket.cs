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
    
    public partial class AuditoriasTicket
    {
        public int IDAuditoriaTicket { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Patente { get; set; }
        public string TipoDeVehiculo { get; set; }
        public int Parcela { get; set; }
        public Nullable<System.DateTime> HorarioDeLlegada { get; set; }
        public Nullable<System.DateTime> HorarioDeSalida { get; set; }
        public Nullable<System.TimeSpan> TiempoTotal { get; set; }
        public Nullable<decimal> PrecioTotal { get; set; }
        public System.DateTime FechaYHora { get; set; }
        public string IP { get; set; }
    }
}
