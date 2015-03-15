using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Patrick Yee";

            return View();
        }

        // this Contact gets the information
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Patrick Yee";
            ViewBag.Message = "Patrick Yee is seeking to be a Full Stack Developer.  If you like what you have seen or have any questions for Patrick Yee, please fill out the form below.";

            return View(new Models.Contact());
        }

        // this Contact posts and send an email to me
        [HttpPost]
        public ActionResult Contact(Models.Contact contact)
        {
            // add to the table in the database
            try
            {
                contact.SentDate = DateTime.Now;  // get the date to be sent
                Models.ContactsEntities db = new Models.ContactsEntities();  // create the context
                // add and save the data
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                // if something is blows up and error will show up
                ViewBag.Error = ex.Message;
                return View("Error");
            }
            
            // email Patrick Yee the message from the website
            MailMessage message = new MailMessage(contact.Email, "PatrickSHYee@gmail.com");
            SmtpClient client = new SmtpClient("mail.dustinkraft.com", 587);

            client.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");

            message.Subject = contact.Subject;
            message.Body = contact.Body;

            client.Send(message);

            return RedirectToAction("ThankYou", "Home");
        }

        public ActionResult ThankYou()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Resume()
        {
            return View();
        }
    }
}