//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstudianteUniversidad.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiante
    {
        public Estudiante()
        {
            this.UniversidadEstudiante = new HashSet<UniversidadEstudiante>();
        }
    
        public int PK_Estudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<System.DateTime> FechaDeNac { get; set; }
        public string sexo { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<UniversidadEstudiante> UniversidadEstudiante { get; set; }
    }
}
