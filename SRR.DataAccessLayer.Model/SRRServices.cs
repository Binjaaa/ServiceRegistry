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
    
    public partial class SRRServices
    {
        public SRRServices()
        {
            this.SRRApplicationUsingServices = new HashSet<SRRApplicationUsingServices>();
            this.SRREntityTagKeywords = new HashSet<SRREntityTagKeywords>();
        }
    
        public int PK_ID { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public int FK_Owner { get; set; }
        public string EndpointDEV { get; set; }
        public string EndpointQA { get; set; }
        public string EndpointPROD { get; set; }
        public string MaxResponseTime { get; set; }
    
        public virtual ICollection<SRRApplicationUsingServices> SRRApplicationUsingServices { get; set; }
        public virtual SRRUsers SRRUsers { get; set; }
        public virtual ICollection<SRREntityTagKeywords> SRREntityTagKeywords { get; set; }
    }
}
