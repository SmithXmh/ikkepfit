﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ikeepfit.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ikeepfitEF : DbContext
    {
        public ikeepfitEF()
            : base("name=ikeepfitEF")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mt_article> mt_article { get; set; }
        public virtual DbSet<mt_articletype> mt_articletype { get; set; }
        public virtual DbSet<mt_course> mt_course { get; set; }
        public virtual DbSet<mt_course_day> mt_course_day { get; set; }
        public virtual DbSet<mt_food> mt_food { get; set; }
        public virtual DbSet<mt_foodtype> mt_foodtype { get; set; }
        public virtual DbSet<mt_knowledge> mt_knowledge { get; set; }
        public virtual DbSet<mt_knowledgemark> mt_knowledgemark { get; set; }
        public virtual DbSet<mt_mark> mt_mark { get; set; }
        public virtual DbSet<mt_plan> mt_plan { get; set; }
        public virtual DbSet<mt_planday> mt_planday { get; set; }
        public virtual DbSet<mt_planmark> mt_planmark { get; set; }
        public virtual DbSet<mt_user> mt_user { get; set; }
        public virtual DbSet<mt_user_collection> mt_user_collection { get; set; }
        public virtual DbSet<mt_user_course> mt_user_course { get; set; }
        public virtual DbSet<mt_user_plan> mt_user_plan { get; set; }
        public virtual DbSet<mt_userfans> mt_userfans { get; set; }
        public virtual DbSet<mt_userlike> mt_userlike { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
