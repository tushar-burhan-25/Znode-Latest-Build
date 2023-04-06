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
    
    public partial class View_GetAllMediaInRoot : ZnodeEntityBaseModel
    {
        public int MediaCategoryId { get; set; }
        public Nullable<int> MediaPathId { get; set; }
        public string Folder { get; set; }
        public string FileName { get; set; }
        public string Size { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Type { get; set; }
        public string MediaType { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int MediaId { get; set; }
        public string Path { get; set; }
        public string MediaServerPath { get; set; }
        public string MediaServerThumbnailPath { get; set; }
        public string FamilyCode { get; set; }
        public int CreatedBy { get; set; }
        public string DisplayName { get; set; }
        public string ShortDescription { get; set; }
        public int Version { get; set; }
    }
}
