using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repoblog.Factories;
using Repoblog.Models.BaseModels;

namespace MVC_Blog.Controllers
{
    public class blogController : Controller
    {
        PostFac pf = new PostFac();
        // GET: blog
        public ActionResult Index()
        {
            return View(pf.GetIndexData());
        }
    }
}