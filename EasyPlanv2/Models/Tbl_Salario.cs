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
    
    public partial class Tbl_Salario
    {
        public int idSalario { get; set; }
        public string CedulaTra { get; set; }
        public int SalarioBruto { get; set; }
        public int Seguro { get; set; }
        public Nullable<int> Prestamos { get; set; }
        public Nullable<int> Adelantos { get; set; }
        public Nullable<int> Otros { get; set; }
        public int SalarioNeto { get; set; }
        public string PrimeraFecha { get; set; }
        public string UltimaFecha { get; set; }
        public int TotalDeducciones { get; set; }
        public string FechaSalario { get; set; }
    
        public virtual Tbl_Trabajador Tbl_Trabajador { get; set; }
    }
}
