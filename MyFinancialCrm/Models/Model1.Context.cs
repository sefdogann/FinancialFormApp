﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFinancialCrm.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinancialCrmDbEntities : DbContext
    {
        public FinancialCrmDbEntities()
            : base("name=FinancialCrmDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankProcesses> BankProcesses { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Spending> Spending { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
