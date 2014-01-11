using SugarMama.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.Models;

namespace SugarMama.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


        [CaptchaMvc.Attributes.CaptchaVerify("Captcha is not valid")]
        [HttpPost]
        public ActionResult Contact(ContactFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var bodyHeader = String.Format("You have a new message from: {0}\r\n\r\n", model.EmailAddress);
                var message = new MailMessage("deborah@sugarmamaskinsugartan.com", "deborah@sugarmamaskinsugartan.com", model.Subject, bodyHeader + model.Body);
                var client = new SmtpClient()
                {
                    Host = "mail.sugarmamaskinsugartan.com",
                    Port = 25,
                };
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("deborah@sugarmamaskinsugartan.com", "sugarmama");
                client.Send(message);

                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Error: captcha is not valid.";
            return View();
        }

        public ActionResult ChartiableWorks()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }
	}
}