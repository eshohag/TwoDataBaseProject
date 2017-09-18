using System.Web.Mvc;
using TwoDataBaseProject.Models;

namespace TwoDataBaseProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Person aPerson)
        {
            MyDbContext aContext = new MyDbContext();
            aContext.Persons.Add(aPerson);
            aContext.SaveChanges();



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