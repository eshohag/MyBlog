using ShohagOnlinePortal.Models;
using ShohagOnlinePortal.MyDbContext;
using System.Linq;
using System.Web.Mvc;

namespace ShohagOnlinePortal.Controllers
{
    //[RoutePrefix("Shohag")]
    public class HomeController : Controller
    {
        SubmitMeDbContext db = new SubmitMeDbContext();
        //[Route("All")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SubmitMeContact aContact)
        {

            if (ModelState.IsValid)
            {
                db.SubmitMeContacts.Add(aContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult All()
        {

            return View(db.SubmitMeContacts.ToList());
        }


    }
}