﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDUniversidadEntities : DbContext
    {
        public BDUniversidadEntities()
            : base("name=BDUniversidadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Universidad> Universidad { get; set; }
        public DbSet<UniversidadEstudiante> UniversidadEstudiante { get; set; }
    }
}