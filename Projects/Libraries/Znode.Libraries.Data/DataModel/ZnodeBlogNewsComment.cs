//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Znode.Libraries.Data.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZnodeBlogNewsComment : ZnodeEntityBaseModel
    {
        public ZnodeBlogNewsComment()
        {
            this.ZnodeBlogNewsCommentLocales = new HashSet<ZnodeBlogNewsCommentLocale>();
        }
    
        public int BlogNewsCommentId { get; set; }
        public Nullable<int> BlogNewsId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ZnodeBlogNew ZnodeBlogNew { get; set; }
        public virtual ICollection<ZnodeBlogNewsCommentLocale> ZnodeBlogNewsCommentLocales { get; set; }
        public virtual ZnodeUser ZnodeUser { get; set; }
    }
}