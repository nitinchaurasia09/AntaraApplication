﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntaraAPI.Models
{
    public class PageMaster
    {
        public string GUID { get; set; }
        public string PageName { get; set; }
        public string PageDescription { get; set; }
        public Nullable<int> PageChild { get; set; }
        public Nullable<int> OrderNumber { get; set; }
    }
}