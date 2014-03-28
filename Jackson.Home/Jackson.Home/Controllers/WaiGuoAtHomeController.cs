using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jackson.Home.Models;
namespace Jackson.Home.Controllers
{
    public class WaiGuoAtHomeController : Controller
    {
        //
        // GET: /WaiGuoAtHome/

        public ActionResult Index()
        {
            var blogContext = new SiteDataDataContext();
            List<BlogPost> blogPosts = blogContext.BlogPosts.Take(10).ToList();
            return View(blogPosts);
        }

    }
}
