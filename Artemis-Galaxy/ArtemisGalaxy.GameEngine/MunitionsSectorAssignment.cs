//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MunitionsSectorAssignment
    {
        public long SectorId { get; set; }
        public int MunitionId { get; set; }
        public Nullable<int> currentAmount { get; set; }
        public int fullAmount { get; set; }
        public int maxAmount { get; set; }
        public int productionWeight { get; set; }
    
        public virtual Munition Munition { get; set; }
        public virtual Sector Sector { get; set; }
    }
}
