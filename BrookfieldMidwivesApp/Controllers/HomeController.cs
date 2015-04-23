using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using BrookfieldMidwivesApp.Models;
using System.Text;

namespace BrookfieldMidwivesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModels c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    MailAddress from = new MailAddress(c.Email.ToString());
                    MailAddress to = new MailAddress("ajfearno@gmail.com");
                    StringBuilder sb = new StringBuilder();
                    MailMessage msg = new MailMessage(from,to);

                    msg.Subject = "Contact Us";
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;
                    msg.IsBodyHtml = false;
                    
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("ajfearno@gmail.com", "Otamabaybeach10");
                    sb.Append("First name: " + c.Name);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + c.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append("Comments: " + c.Message);
                    msg.Body = sb.ToString();
                    smtp.Send(msg);
                    msg.Dispose();
                    ViewBag.Message = "Message Sent";
                    return View();
                    
                }
                catch (Exception)
                {
                    ViewBag.Message = "Message Failed, Please check your details carefully then resend";
                    return View();
                }
            }
                    return View();
                }
            
        


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}