﻿using System.Collections.Generic;
using Znode.Engine.Admin.Models;

namespace Znode.Engine.Admin.ViewModels
{
    public class PIMAttributeGroupMapperListViewModel :BaseViewModel
    {
        public GridModel GridModel { get; set; }
        public List<PIMAttributeGroupMapperViewModel> AttributeGroupMappers { get; set; }

        public int PimAttributeGroupId { get; set; }
        public bool IsNonEditable { get; set; }
    }
}