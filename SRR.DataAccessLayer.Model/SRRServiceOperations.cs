//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRR.DataAccessLayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SRRServiceOperations
    {
        public SRRServiceOperations()
        {
            this.Tags = new HashSet<SRREntityTagKeywords>();
            this.SRRServiceOperations1 = new HashSet<SRRServiceOperations>();
            this.SRRServiceOperations2 = new HashSet<SRRServiceOperations>();
        }
    
        public int PK_ID { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Description { get; set; }
        public Nullable<int> FK_RequestMessage { get; set; }
        public Nullable<int> FK_ResponseMessage { get; set; }
    
        public virtual SRRServiceMessages RequestMessage { get; set; }
        public virtual SRRServiceMessages ResponseMessage { get; set; }
        public virtual ICollection<SRREntityTagKeywords> Tags { get; set; }
        public virtual ICollection<SRRServiceOperations> SRRServiceOperations1 { get; set; }
        public virtual ICollection<SRRServiceOperations> SRRServiceOperations2 { get; set; }
    }
}