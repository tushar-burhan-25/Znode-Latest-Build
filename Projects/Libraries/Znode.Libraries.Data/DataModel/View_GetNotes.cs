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
    
    public partial class View_GetNotes : ZnodeEntityBaseModel
    {
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> CaseRequestId { get; set; }
        public string NoteTitle { get; set; }
        public string NoteBody { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
    }
}
