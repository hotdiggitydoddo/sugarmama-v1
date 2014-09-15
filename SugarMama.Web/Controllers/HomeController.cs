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
            return View("Index", "~/Views/Shared/_SplashLayout.cshtml");
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
                    Host = "smtp.gmail.com",
                    Port = 587,
                };
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("deborah@sugarmamaskinsugartan.com", "sugarmama");
                client.Send(message);
                TempData["flash"] = "Your message was successfully sent!  Thank you.";
                return RedirectToAction("Contact");
            }
            TempData["ErrorMessage"] = "Error: captcha is not valid.";
            return View();
        }

        public ActionResult ChartiableWorks()
        {
            return View();
        }

        public ActionResult Promotions()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }

        public ActionResult Appointments()
        {
            return View();
        }

        public ActionResult HairRemoval()
        {
            return View();
        }

        public ActionResult Tanning()
        {
            return View();
        }

        public ActionResult Facials()
        {
            return View();
        }

        public ActionResult Peels()
        {
            return View();
        }

        public ActionResult Picks()
        {
            return View();
        }
	}
}