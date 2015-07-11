using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntaraAPI.Models
{
    public class PageImages
    {
        public Guid GUID { get; set; }
        public Guid PageId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageText { get; set; }
        public string ImageControl { get; set; }
        public string LabelControl { get; set; }
        public string Description { get; set; }
    }
}