using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AntaraWebApi.Models;

namespace AntaraWebApi.Repository
{
    public class PageRepository
    {
        AntaraWebApi.Repository.AntaraEntities dbContext;
        public PageRepository()
        {
            dbContext = new AntaraEntities();
        }

        public IList<PageMaster> GetPages()
        {
            List<PageMaster> result = new List<PageMaster>();

            result = (from pm in dbContext.page_master
                      select new PageMaster
                      {
                          GUID = pm.GUID,
                          PageName = pm.PageName,
                          PageDescription = pm.PageDescription,
                          PImages = dbContext.page_image_text_master.Where(y => y.PageId == pm.GUID).Select(pitm => new PageImages { PageId = pitm.PageId, LabelControl = pitm.LabelControl, ImageUrl = pitm.ImageUrl, ImageText = pitm.ImageText, ImageControl = pitm.ImageControl, Description = pitm.Description }).AsEnumerable()
                      }).ToList();
            return result;
        }

        public IList<YTMaster> GetAllYouTubeLinks()
        {
            List<YTMaster> result = new List<YTMaster>();
            result = dbContext.youtube_master.Select(x => new YTMaster { GUID = x.GUID, YouTubeLink = x.YouTubeLink, YouTubeText = x.YouTubeText }).ToList();
            return result;
        }
    }
}