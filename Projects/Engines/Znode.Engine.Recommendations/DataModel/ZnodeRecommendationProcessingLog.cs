//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Znode.Engine.Recommendations.DataModel
{
    using System;
    using System.Collections.Generic;
    using Znode.Libraries.Data;
    
    public partial class ZnodeRecommendationProcessingLog : ZnodeEntityBaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZnodeRecommendationProcessingLog()
        {
            this.ZnodeRecommendationBaseProducts = new HashSet<ZnodeRecommendationBaseProduct>();
        }
    
        public int RecommendationProcessingLogsId { get; set; }
        public Nullable<int> PortalId { get; set; }
        public string Status { get; set; }
        public int LastProcessedOrderId { get; set; }
        public System.DateTime LastProcessedOrderDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZnodeRecommendationBaseProduct> ZnodeRecommendationBaseProducts { get; set; }
    }
}
