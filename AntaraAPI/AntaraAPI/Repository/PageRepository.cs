using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AntaraAPI.Models;

namespace AntaraAPI.Repository
{
    public class PageRepository
    {
        AntaraAPI.Repository.antaraEntities dbContext;
        public PageRepository()
        {
            dbContext = new antaraEntities();
        }

        public IList<PageMaster> GetPages()
        {
            List<PageMaster> result = new List<PageMaster>();
            result = dbContext.page_master.Select(x => new PageMaster { GUID = x.GUID, PageName = x.PageName, PageDescription = x.PageDescription }).ToList();
            return result;
        }

    }
}