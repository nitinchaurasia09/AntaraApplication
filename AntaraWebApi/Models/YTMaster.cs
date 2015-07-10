using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntaraWebApi.Models
{
    public class YTMaster
    {
        public Guid GUID { get; set; }
        public string YouTubeLink { get; set; }
        public Nullable<int> NumberOfTimeExecuted { get; set; }
        public string YouTubeText { get; set; }
    }
}