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
    
    public partial class Tbl_Trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Trabajador()
        {
            this.Tbl_Adelantos = new HashSet<Tbl_Adelantos>();
            this.Tbl_Jornada = new HashSet<Tbl_Jornada>();
            this.Tbl_Prestamos = new HashSet<Tbl_Prestamos>();
            this.Tbl_Salario = new HashSet<Tbl_Salario>();
        }
    
        public string CedulaTra { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public int NumEmpleado { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string FechaEmpleo { get; set; }
        public string Empleador { get; set; }
        public string FechaDespido { get; set; }
        public string InicioIncapacidad { get; set; }
        public string FinalIncapacidad { get; set; }
        public string Padecimientos { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Adelantos> Tbl_Adelantos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Jornada> Tbl_Jornada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Prestamos> Tbl_Prestamos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Salario> Tbl_Salario { get; set; }
    }
}
