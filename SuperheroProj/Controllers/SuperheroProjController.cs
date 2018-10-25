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

            return View(superHeroes.ToList());

        }
        [HttpGet]
        public ActionResult Details (int Id = 0)
        {
            SuperheroProj.Models.SuperheroProj superhero = db.SuperheroProj.Find(Id);
            return View(superhero);
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
        [HttpPost]
        public ActionResult Details(SuperheroProj.Models.SuperheroProj superhero)
        {
            return View(superhero);
        }


        public ActionResult Edit (int id = 0)
        {                   
            SuperheroProj.Models.SuperheroProj superhero = db.SuperheroProj.Find(id);
            
            return View(superhero);          
        }

        [HttpPost]
        public ActionResult Edit (SuperheroProj.Models.SuperheroProj superhero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(superhero).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(superhero);
        }

        public ActionResult Delete(int? id)
        {

            SuperheroProj.Models.SuperheroProj superhero = db.SuperheroProj.Find(id);
            if (superhero == null) 
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuperheroProj.Models.SuperheroProj superhero = db.SuperheroProj.Find(id);
            db.SuperheroProj.Remove(superhero);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }

}