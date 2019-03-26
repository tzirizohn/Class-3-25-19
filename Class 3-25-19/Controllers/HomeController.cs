using Class_3_25_19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class_3_25_19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonManager pm = new PersonManager(Properties.Settings.Default.Constr);
            IEnumerable<Person> ppl = pm.GetPeople();
            return View(ppl);
        }  
       
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult AddPerson(List<Person>p)
        {
            PersonManager pm = new PersonManager(Properties.Settings.Default.Constr);
            pm.AddPerson(p);
            return Redirect("/home/index");
        }
    }
}