﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practica_02_crud_desktop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_CooperativaEntities : DbContext
    {
        public DB_CooperativaEntities()
            : base("name=DB_CooperativaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CREDITO> CREDITO { get; set; }
        public virtual DbSet<CUENTA> CUENTA { get; set; }
        public virtual DbSet<DETALLE_CREDITO> DETALLE_CREDITO { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<PERSONA> PERSONA { get; set; }
        public virtual DbSet<SOCIO> SOCIO { get; set; }
        public virtual DbSet<SUCURSAL> SUCURSAL { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPO_CREDITO> TIPO_CREDITO { get; set; }
        public virtual DbSet<TIPO_CUENTA> TIPO_CUENTA { get; set; }
        public virtual DbSet<TIPO_IDENTIFICACION> TIPO_IDENTIFICACION { get; set; }
        public virtual DbSet<TIPO_TRANSACCION> TIPO_TRANSACCION { get; set; }
        public virtual DbSet<TRANSACCION> TRANSACCION { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<PERMISOWS> PERMISOWS { get; set; }
    }
}
