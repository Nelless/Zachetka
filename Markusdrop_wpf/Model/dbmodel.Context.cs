﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Markusdrop_wpf.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class armmarkdbEntities : DbContext
    {
        public armmarkdbEntities()
            : base("name=armmarkdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<company_areas> company_areas { get; set; }
        public DbSet<company_task> company_task { get; set; }
        public DbSet<employee_task> employee_task { get; set; }
        public DbSet<user_auth> user_auth { get; set; }
        public DbSet<user_role> user_role { get; set; }
        public DbSet<users> users { get; set; }
    }
}