﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_commerce1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class e_commeranceEntities : DbContext
    {
        public e_commeranceEntities()
            : base("name=e_commeranceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cart_> cart_ { get; set; }
        public virtual DbSet<cartitem> cartitems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_> User_ { get; set; }
    }
}
