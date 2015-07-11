using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using AntaraAPI.Models;
using AntaraAPI.Repository;

namespace AntaraAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PageController : ApiController
    {
        PageRepository pageRepository;
        public PageController()
        {
            this.pageRepository = new PageRepository();
        }

        public IList<PageMaster> GetAllPages()
        {
            return this.pageRepository.GetPages();
        }
    }
}
