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
    
    public partial class EMAILRECIPIENTSLIST
    {
        public int EmailRecipientsListID { get; set; }
        public int EmailRecipientsID { get; set; }
        public string EmailRecipientsGUID { get; set; }
        public int EmailRecipientID { get; set; }
        public string EmailRecipientGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> ConfidenceReasonID { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public Nullable<int> TrustReasonID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual COLLECTIONMETHOD COLLECTIONMETHOD { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual CONFIDENCEREASON CONFIDENCEREASON { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual EMAILRECIPIENT EMAILRECIPIENT { get; set; }
        public virtual EMAILRECIPIENTS EMAILRECIPIENTS { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual TRUSTREASON TRUSTREASON { get; set; }
    }
}