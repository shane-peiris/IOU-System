//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IOUSystems
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobCosting
    {
        public int ID { get; set; }
        public Nullable<int> JobID { get; set; }
        public Nullable<int> CostElementID { get; set; }
        public Nullable<System.DateTime> DateOfRecord { get; set; }
        public string PVNo { get; set; }
        public string Payee { get; set; }
        public string Descriptions { get; set; }
        public decimal Cost { get; set; }
        public string Claimable { get; set; }
        public Nullable<int> RecordBy { get; set; }
        public Nullable<System.DateTime> dt_lmd { get; set; }
        public Nullable<int> modify_By { get; set; }
    
        public virtual CostElement CostElement { get; set; }
        public virtual Job Job { get; set; }
    }
}
