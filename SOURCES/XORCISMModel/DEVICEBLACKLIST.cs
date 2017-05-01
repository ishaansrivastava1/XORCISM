//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEVICEBLACKLIST
    {
        public int DeviceBlacklistID { get; set; }
        public int DeviceID { get; set; }
        public Nullable<int> OrganisationID { get; set; }
        public Nullable<int> PersonID { get; set; }
        public Nullable<int> AssetID { get; set; }
        public Nullable<int> CreatedDate { get; set; }
        public Nullable<int> ValidFromDate { get; set; }
        public Nullable<int> ValidUntilDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
    
        public virtual ASSET ASSET { get; set; }
        public virtual DEVICE DEVICE { get; set; }
        public virtual ORGANISATION ORGANISATION { get; set; }
        public virtual PERSON PERSON { get; set; }
    }
}