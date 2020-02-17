using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TRM.Controllers
{
    public class TRM1Controller : Controller
    {
        // GET: TRM1
        [HttpPost]
        public ActionResult Index(string re, string sk, DateTime st, DateTime en)
        {
            ASSESMENTEntities ctx = new ASSESMENTEntities();
            TRM tr = new TRM();
            tr.REQUESTNAME = re;
            tr.SKILL = sk;
            tr.STARTDATE = st;
            tr.ENDDATE = en;
            ctx.TRMs.Add(tr);
            ctx.SaveChanges();
            return View();
        }
            public ActionResult Index()
        {
           
            return View();
        }
    }
}