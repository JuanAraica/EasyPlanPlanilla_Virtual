using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyPlanv2.Models.ViewModel
{
    public class Trabajador
    {
 

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