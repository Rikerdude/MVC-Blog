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

        public ActionResult Edit(int id)
        {
            return View(pf.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Post p)
        {
            p.Dato = DateTime.Now;

            if (ModelState.IsValid)
            {
                pf.Update(p);
            }
            return View(pf.Get(p.ID));
        }

        public ActionResult Delete(int id)
        {
            
        }
    }
}