﻿namespace Znode.Engine.Admin.ViewModels
{
    public class PortalSearchProfileViewModel : BaseViewModel
    {
        public int PortalSearchProfileId { get; set; }
        public int PublishCatalogId { get; set; }
        public int SearchProfileId { get; set; }
        public int PortalId { get; set; }
        public bool IsDefault { get; set; }
    }
}
