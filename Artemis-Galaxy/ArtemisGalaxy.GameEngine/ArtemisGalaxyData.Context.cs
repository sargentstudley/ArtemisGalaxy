﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtemisGalaxy.GameEngine
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ArtemisGalaxyDevEntities : DbContext
    {
        public ArtemisGalaxyDevEntities()
            : base("name=ArtemisGalaxyDevEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CampaignEnrollment> CampaignEnrollments { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Ship> Ships { get; set; }
    }
}
