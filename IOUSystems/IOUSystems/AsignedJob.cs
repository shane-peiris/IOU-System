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
    
    public partial class AsignedJob
    {
        public int ID { get; set; }
        public Nullable<int> JobID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> DateofAssigned { get; set; }
        public Nullable<int> AssignedBy { get; set; }
        public Nullable<System.DateTime> dt_lmd { get; set; }
        public Nullable<int> modify_By { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Job Job { get; set; }
    }
}