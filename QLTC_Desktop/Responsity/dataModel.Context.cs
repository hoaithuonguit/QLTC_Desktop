﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTC_Desktop.Responsity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTCDbEntities : DbContext
    {
        public QLTCDbEntities()
            : base("name=QLTCDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionName> ActionNames { get; set; }
        public virtual DbSet<MemoryAction> MemoryActions { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
    }
}