using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using mail.Models;

namespace mail.Controllers
{
    public class mailController : Controller
    {
        // GET: mail
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(string un, string pass)
        {
            ASSESMENTEntities3 ctx = new ASSESMENTEntities3();
            //MAIL ml = new MAIL();
            //MailDetail md = new MailDetail();
            var res = ctx.MAILs.Where(n => n.Username == un && n.password1 == pass).FirstOrDefault();
            if (res != null)
            {
                return Redirect("/mail/Process?ID="+res.UserID);

            }
            ViewBag.msg = "user id and password not mmatch";
            return View();
        }
        public ActionResult Process()
        {
            int id = int.Parse(Request["ID"]);
            InboxViewModel  model = new InboxViewModel();
            ASSESMENTEntities3 ctx = new ASSESMENTEntities3();
            var obj = ctx.MailDetails.Where(u => u.UserID == id);
            foreach (var o in obj)
            {
                                
                    MailDetail ml = new MailDetail();
                    ml.MailID = o.MailID;
                    ml.MailForm = o.MailForm;
                    ml.Subject1 = o.Subject1;
                    ml.ReceiveDate = o.ReceiveDate;
                    ml.Messsage = o.Messsage;
                    model.mlist.Add(ml);
            }
                return View(model);
            

        }
        public ActionResult DETAILS()
        {
            int id = int.Parse(Request["MID"]);
            InboxViewModel model = new InboxViewModel();
            ASSESMENTEntities3 ctx = new ASSESMENTEntities3();
            var o = ctx.MailDetails.Where(u => u.MailID == id).FirstOrDefault();

            MAilDetails ml = new MAilDetails();
                ml.MailID = o.MailID;
                ml.MailForm = o.MailForm;
                ml.Subject1 = o.Subject1;
                ml.ReceiveDate = o.ReceiveDate;
                ml.Messsage = o.Messsage;

            return View(ml);
        }
    }
}