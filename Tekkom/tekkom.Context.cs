﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tekkom
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tekkomEntities : DbContext
    {
        public tekkomEntities()
            : base("name=tekkomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<objek> objek { get; set; }
        public DbSet<pelengkap> pelengkap { get; set; }
        public DbSet<predikat> predikat { get; set; }
        public DbSet<subjek> subjek { get; set; }
    }
}