using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemo2.Models;


namespace mvcdemo2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        projectEntities db = new projectEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(inquiry con)
        {
            try
            {
                con.inquirydate = DateTime.Now.ToString();
                db.inquiries.Add(con);
                db.SaveChanges();
                Response.Write("<script>alert('Record saved')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Record not saved')</script>");
            }
            return View();
        }
       
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(suggetion con)
        {
            try {
                con.suggetiondate = DateTime.Now.ToString();
                db.suggetions.Add(con);
                db.SaveChanges();
                Response.Write("<script>alert('Record saved')</script>");
            }
            catch(Exception ex)
            {
             Response.Write("<script>alert('Record not saved')</script>");
            }
            return View();
        }
       
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(ptable con)
        {
            try
            {
                con.contactdate = DateTime.Now.ToString();
                db.ptables.Add(con);
                db.SaveChanges();
                Response.Write("<script>alert('Record Saved sucessfully')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Record not Saved')</script>");
            }
            return View();
        }
        
        public ActionResult schemes()
        {
            return View();
        }
        public ActionResult signup()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult signup(registration reg,string hdn1,string ct1)
        {
            try
            {
               if(hdn1==ct1)
               {
                   //start code of file
                   HttpPostedFileBase file = Request.Files["profile"];
                   reg.profile = file.FileName;
                   //end code of file.
                   reg.regdate = DateTime.Now.ToString();
                   file.SaveAs(Server.MapPath("~/Content/img/" + file.FileName));
                   db.registrations.Add(reg);
                   db.SaveChanges();
                   Response.Write("<script>alert('Data saved successfully');window.location.href='/home/signup'; </script>");
               }
               else
               {
                   Response.Write("<script>alert('Invalid Capta Codes');window.location.href='/home/signup'; </script>");
               }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Data not saved')</script>");
            }
            return View();
        }
       
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(login lg)
        {
            try
            {
                login t1 = db.logins.Where(x => x.email == lg.email && x.pass == lg.pass).SingleOrDefault();
                if (t1 != null)
                {
                    Session["aid"]=lg.email;     //Set of session 
                    Response.Write("<script>alert('welcome To Admin Zone');window.location.href='/Admin/Index'</script>");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Email or Password')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Invalid Email or Password')</script>");
            }
            return View();
        }
        public ActionResult complain()
        {
            return View();
        }
        [HttpPost]
        public ActionResult complain(complain con)
        {
            try
            {
                con.comlaindate= DateTime.Now.ToString();  //use date &time
                db.complains.Add(con);//Record insert
                db.SaveChanges();    // save values as permanently
                Response.Write("<script>alert('Record saved')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Record not saved')</script>");
            }
            return View();
        }
        
        public ActionResult feedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult feedback(feedback fed)
        {
            try
            {
                fed.feedbackdate = DateTime.Now.ToString();
                db.feedbacks.Add(fed);
                db.SaveChanges();
                Response.Write("<script>alert('Data Saved SucssFully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Data not Saved')</script>");
            }
            return View();
        }
        
        public ActionResult forgetpass()
        {
            return View();
        }

       

    }
}
