﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class testEntities : DbContext
    {
        public testEntities()
            : base("name=testEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cities> cities { get; set; }
        public virtual DbSet<clients> clients { get; set; }
    
        public virtual ObjectResult<ssp_getCities_Result> ssp_getCities()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ssp_getCities_Result>("ssp_getCities");
        }
    }
}
