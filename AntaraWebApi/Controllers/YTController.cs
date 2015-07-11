using AntaraWebApi.Models;
using AntaraWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AntaraWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class YTController : ApiController
    {
        PageRepository pageRepository;
        public YTController()
        {
            this.pageRepository = new PageRepository();
        }
        
        public IList<YTMaster> GetAllYouTubeLink()
        {
            return this.pageRepository.GetAllYouTubeLinks();
        }
    }
}
