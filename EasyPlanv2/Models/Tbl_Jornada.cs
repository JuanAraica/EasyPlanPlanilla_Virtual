//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyPlanv2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Jornada
    {
        public int idJornada { get; set; }
        public string CedulaTra { get; set; }
        public string TipoJornada { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public Nullable<int> PrecioHoraRegular { get; set; }
        public Nullable<int> PrecioHoraExtra { get; set; }
        public Nullable<int> CantidadHorasRegulares { get; set; }
        public Nullable<int> CantidadHorasExtras { get; set; }
        public Nullable<int> ValorTotalHoraExtra { get; set; }
        public Nullable<int> ValorTotalHorasRegulares { get; set; }
        public Nullable<int> PrecioDia { get; set; }
        public string UnidadMedida { get; set; }
        public Nullable<int> PrecioUnidadMedida { get; set; }
        public Nullable<int> ValorTotalUnidadMedida { get; set; }
        public Nullable<int> PrecioMetro { get; set; }
        public Nullable<byte> PrecioPaquete { get; set; }
        public string LaborExtra { get; set; }
        public Nullable<int> PrecioLaborExtra { get; set; }
        public string FechaJornada { get; set; }
        public int SalarioJornada { get; set; }
        public string Observacion { get; set; }
    
        public virtual Tbl_Trabajador Tbl_Trabajador { get; set; }
    }
}
