using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemo2.Models;

namespace mvcdemo2.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        projectEntities db = new projectEntities();

        public ActionResult Index()
        {
            if (Session["aid"] != null)
            {

            }
            else
            {
                Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
            }
            return View();
        }
        public ActionResult IndexMGMT()
        {
            if (Session["aid"] != null)
            {

            }
            else
            {
                Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
            }
            List<inquiry> lst = null;
            lst = db.inquiries.ToList();
            return View(lst);
        }
        public void DeleteInd(int id)
        {
            try
            {
                inquiry del = db.inquiries.SingleOrDefault(x => x.id == id);
                db.inquiries.Remove(del);
                db.SaveChanges();

                Response.Write("<script>alert('Deleted');window.location.href='/Admin/IndexMGMT'</script>");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Not Delete');window.location.href='/Admin/IndexMGMT'</script>");

            }
        }
        [HttpGet]
        public ActionResult UpdateInd()
        {
            string email = Request.QueryString["u"];
            inquiry reg = db.inquiries.SingleOrDefault(a => a.email == email);

            return View(reg);
        }
        [HttpPost]
        public void UpdateInd(inquiry reg, string email)
        {


            inquiry rg = db.inquiries.SingleOrDefault(a => a.email == email);


            try
            {
                inquiry rr = db.inquiries.SingleOrDefault(x => x.email == email);

                rr.name = reg.name;
                rr.mob = reg.mob;
                rr.email = reg.email;
                rr.inquirydate = DateTime.Now.ToString();

                db.SaveChanges();
                Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/IndexMGMT'</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Record  not update ');window.location.href='/admin/IndexMGMT'</script>");
            }
        }
        public ActionResult ContactMGMT()
        {
            if (Session["aid"] != null)
            {

            }
            else
            {
                Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
            }

            List<ptable> lst = null;
            lst = db.ptables.ToList();
            return View(lst);
        }
        public void DeleteCon(int id)
        {
            try
            {
                ptable del = db.ptables.SingleOrDefault(x => x.id == id);
                db.ptables.Remove(del);
                db.SaveChanges();

                Response.Write("<script>alert('Deleted');window.location.href='/Admin/ContactMGMT'</script>");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Not Delete');window.location.href='/Admin/ContactMGMT'</script>");

            }
        }
        [HttpGet]
        public ActionResult UpdateCon()
        {
            string email = Request.QueryString["u"];
            ptable reg = db.ptables.SingleOrDefault(a => a.email == email);

            return View(reg);
        }
        [HttpPost]
        public void UpdateCon(ptable reg, string email)
        {


            ptable rg = db.ptables.SingleOrDefault(a => a.email == email);


            try
            {
                ptable rr = db.ptables.SingleOrDefault(x => x.email == email);

                rr.name = reg.name;
                rr.mob = reg.mob;
                rr.email = reg.email;
                rr.address = reg.address;
                rr.contactdate = DateTime.Now.ToString();

                db.SaveChanges();
                Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/ContactMGMT'</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Record  not update ');window.location.href='/admin/ContactMGMT'</script>");
            }
        }
         public ActionResult AboutMGMT()
        {
            if (Session["aid"] != null)
            {

            }
            else
            {
                Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
            }
            List<suggetion> lst = null;
            lst = db.suggetions.ToList();
            return View(lst);
        }
         public void DeleteAbo(int id)
         {
             try
             {
                 suggetion del = db.suggetions.SingleOrDefault(x => x.id == id);
                 db.suggetions.Remove(del);
                 db.SaveChanges();

                 Response.Write("<script>alert('Deleted');window.location.href='/Admin/AboutMGMT'</script>");
             }
             catch (Exception ex)
             {

                 Response.Write("<script>alert('Not Delete');window.location.href='/Admin/AboutMGMT'</script>");

             }
         }
         [HttpGet]
         public ActionResult UpdateAbo()
         {
             string email = Request.QueryString["u"];
             suggetion reg = db.suggetions.SingleOrDefault(a => a.email == email);

             return View(reg);
         }
         [HttpPost]
         public void UpdateAbo(suggetion reg, string email)
         {


             suggetion rg = db.suggetions.SingleOrDefault(a => a.email == email);


             try
             {
                 suggetion rr = db.suggetions.SingleOrDefault(x => x.email == email);

                 rr.name = reg.name;
                 rr.mob = reg.mob;
                 rr.email = reg.email;
                 rr.msg = reg.msg;
                 rr.suggetiondate = DateTime.Now.ToString();

                 db.SaveChanges();
                 Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/AboutMGMT'</script>");
             }
             catch (Exception ex)
             {
                 Response.Write("<script>alert('Record  not update ');window.location.href='/admin/AboutMGMT'</script>");
             }
         }
         public ActionResult SignupMGMT()
         {
             if (Session["aid"] != null)
             {

             }
             else
             {
                 Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
             }
             List<registration> lst = null;
             lst = db.registrations.ToList();
             return View(lst);
         }
         public void DeleteSi(int id)
         {
             try
             {
                 registration del = db.registrations.SingleOrDefault(x => x.id == id);
                 db.registrations.Remove(del);
                 db.SaveChanges();

                 Response.Write("<script>alert('Deleted');window.location.href='/Admin/SignupMGMT'</script>");
             }
             catch (Exception ex)
             {

                 Response.Write("<script>alert('Not Delete');window.location.href='/Admin/SignupMGMT'</script>");

             }
         }
         [HttpGet]
         public ActionResult Updatereg()
         {
             string email = Request.QueryString["u"];
             registration reg = db.registrations.SingleOrDefault(a => a.email == email);

             return View(reg);
         }
         [HttpPost]
         public void Updatereg(registration reg, string email)
         {


             registration rg = db.registrations.SingleOrDefault(a => a.email == email);


             try
             {
                 HttpPostedFileBase file = Request.Files["profile"];
                 if (file.FileName != "")
                 {
                     rg.name = reg.name;
                     rg.mob = reg.mob;
                     rg.email = reg.email;
                     rg.dob = reg.dob;
                     rg.profile = file.FileName;
                     rg.qualification = reg.qualification;
                     rg.gender = reg.gender;
                     rg.pass = reg.pass;
                     rg.district = reg.district;
                     rg.address = reg.address;
                     rg.regdate = DateTime.Now.ToString();
                     db.SaveChanges();
                     file.SaveAs(Server.MapPath("~/Content/img/" + file.FileName));
                     Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/SignupMGMT'</script>");
                 }
                 else
                 {
                     registration dd = db.registrations.SingleOrDefault(x => x.email == email);
                     dd.name = reg.name;
                     dd.mob = reg.mob;
                     dd.email = reg.email;
                     dd.dob = reg.dob;
                     //dd.profile = file.FileName;
                     dd.qualification = reg.qualification;
                     dd.gender = reg.gender;
                     dd.pass = reg.pass;
                     dd.district = reg.district;
                     dd.address = reg.address;
                     dd.regdate = DateTime.Now.ToString();
                     db.SaveChanges();
                     //file.SaveAs(Server.MapPath("~/Content/img/" + file.FileName));
                     Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/SignupMGMT'</script>");
                 }
             }
             catch (Exception ex)
             {
                 Response.Write("<script>alert('Record  not update ');window.location.href='/admin/SignupMGMT'</script>");
             }
         }
         public ActionResult ComplainMGMT()
         {
             if (Session["aid"] != null)
             {

             }
             else
             {
                 Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
             }
             List<complain> lst = null;
             lst = db.complains.ToList();
             return View(lst);
         }
         public void DeleteCom(int id)
         {
             try
             {
                 complain del = db.complains.SingleOrDefault(x => x.id == id);
                 db.complains.Remove(del);
                 db.SaveChanges();

                 Response.Write("<script>alert('Deleted');window.location.href='/Admin/ComplainMGMT'</script>");
             }
             catch (Exception ex)
             {

                 Response.Write("<script>alert('Not Delete');window.location.href='/Admin/ComplainMGMT'</script>");

             }
         }
         [HttpGet]
         public ActionResult UpdateCom()
         {
             string email = Request.QueryString["u"];
             complain reg = db.complains.SingleOrDefault(a => a.email == email);

             return View(reg);
         }
         [HttpPost]
         public void UpdateCom(complain reg, string email)
         {


             complain rg = db.complains.SingleOrDefault(a => a.email == email);


             try
             {
                 complain rr = db.complains.SingleOrDefault(x => x.email == email);

                 rr.name = reg.name;
                 rr.mob = reg.mob;
                 rr.email = reg.email;
                 rr.msg = reg.msg;
                 rr.comlaindate = DateTime.Now.ToString();

                 db.SaveChanges();
                 Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/ComplainMGMT'</script>");
             }
             catch (Exception ex)
             {
                 Response.Write("<script>alert('Record  not update ');window.location.href='/admin/ComplainMGMT'</script>");
             }
         }
         public ActionResult FeedbackMGMT()
         {
             if (Session["aid"] != null)
             {

             }
             else
             {
                 Response.Write("<script>alert('Login First');window.location.href='/Home/login'</script>");
             }
             List<feedback> lst = null;
             lst = db.feedbacks.ToList();
             return View(lst);
         }
         public void DeleteFed(int id)
         {
             try
             {
                 feedback del = db.feedbacks.SingleOrDefault(x => x.id == id);
                 db.feedbacks.Remove(del);
                 db.SaveChanges();

                 Response.Write("<script>alert('Deleted');window.location.href='/Admin/FeedbackMGMT'</script>");
             }
             catch (Exception ex)
             {

                 Response.Write("<script>alert('Not Delete');window.location.href='/Admin/FeedbackMGMT'</script>");

             }
         }
         [HttpGet]
         public ActionResult UpdateFed()
         {
             string email = Request.QueryString["u"];
             feedback reg = db.feedbacks.SingleOrDefault(a => a.email == email);

             return View(reg);
         }
         [HttpPost]
         public void UpdateFed(feedback reg, string email)
         {


             feedback rg = db.feedbacks.SingleOrDefault(a => a.email == email);


             try
             {
                 feedback rr = db.feedbacks.SingleOrDefault(x => x.email == email);

                 rr.name = reg.name;
                 rr.mob = reg.mob;
                 rr.email = reg.email;
                 rr.msg = reg.msg;
                 rr.feedbackdate = DateTime.Now.ToString();

                 db.SaveChanges();
                 Response.Write("<script>alert('Record  update Successfully');window.location.href='/admin/FeedbackMGMT'</script>");
             }
             catch (Exception ex)
             {
                 Response.Write("<script>alert('Record  not update ');window.location.href='/admin/FeedbackMGMT'</script>");
             }
         }
         public ActionResult changepass()
         {
             return View();
         }
        [HttpPost]
         public ActionResult changepass(string oldpass,string newpass,string confirmpass)
         {
             if (newpass == confirmpass)
             {
                 string Email = Session["aid"].ToString();
                 login lg = db.logins.Where(x => x.pass == oldpass && x.email == x.email).SingleOrDefault();
                 lg.pass =newpass;
                 db.SaveChanges();
                 Response.Write("<script>alert('Password Changed Successfully');window.location.href='/Home/login'</script>");
             }
             else
             {
                 Response.Write("<script>alert('Password Not Matched');window.location.href='/Admin/changepass'</script>"); 
             }
            
             return View();
         }
         public void Logout()
         {
             Session.Abandon();
             Response.Write("<script>alert('Logout');window.location.href='/Home/login'</script>");
         }

    }
}
