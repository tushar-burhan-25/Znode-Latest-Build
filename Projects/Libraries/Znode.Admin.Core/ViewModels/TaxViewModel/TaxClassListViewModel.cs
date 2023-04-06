﻿using System.Collections.Generic;
using Znode.Engine.Admin.Models;

namespace Znode.Engine.Admin.ViewModels
{
    public class TaxClassListViewModel : BaseViewModel
    {
        public List<TaxClassViewModel> TaxClassList { get; set; }
        public GridModel GridModel { get; set; }
        public int? PortalId { get; set; }
        public string PortalName { get; set; }
    }
}