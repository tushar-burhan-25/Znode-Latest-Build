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
    
    public partial class View_Table_FK_Details : ZnodeEntityBaseModel
    {
        public string TABLE_NAME { get; set; }
        public string CONSTRAINT_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public string UPDATE_RULE { get; set; }
        public string DELETE_RULE { get; set; }
        public string REF_TABLE_NAME { get; set; }
        public string REF_COLUMN_NAME { get; set; }
        public string REF_CONSTRAINT_NAME { get; set; }
    }
}
