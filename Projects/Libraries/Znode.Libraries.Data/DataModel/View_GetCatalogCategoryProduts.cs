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
    
    public partial class View_GetCatalogCategoryProduts : ZnodeEntityBaseModel
    {
        public int RowId { get; set; }
        public int PimProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> PimCatalogId { get; set; }
        public int PimCategoryId { get; set; }
        public int Localeid { get; set; }
    }
}