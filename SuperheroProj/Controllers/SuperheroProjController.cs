using SuperheroProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroProj.Controllers
{
    public class SuperheroProjController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: SuperheroProj
        public ActionResult Index()
        {
            
            var superHeroes = db.SuperheroProj;

            return View(superHeroes);
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]

        public ActionResult Create([Bind(Include ="Name,AlterName,Ability,SecondAbility,Catchphrase")] SuperheroProj.Models.SuperheroProj superhero)
        {                   
               db.SuperheroProj.Add(superhero);
               db.SaveChanges();
                return RedirectToAction("Index");
                                 
        }

        public ActionResult Details(SuperheroProj.Models.SuperheroProj superhero)
        {
            return View();
        }

        public ActionResult Edit ()//int id)
        {
            //SuperheroProj.Models.SuperheroProj superhero = db.SuperheroProj.Find(id);
            //if (superhero == null)
            //{
            //    return HttpNotFound();
            //}
            return View("Create");

        }

            






    }

}