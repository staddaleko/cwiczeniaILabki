using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S1.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace S1.Controllers
{
    public class HomeController : Controller
    {
        private AutorDataContext db_A = new AutorDataContext();
        private KsiazkaDataContext db_K = new KsiazkaDataContext();

        public ActionResult Index()
        {
            return View("Index", db_A.Autorzy.ToList());
        }

        public ActionResult Create_A()
        {
            return View("Create_A");
        }

        [HttpPost]
        public ActionResult Create_A(Autor A)
        {
            if (ModelState.IsValid)
            {
                db_A.Autorzy.Add(A);
                db_A.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Created_A", A);
        }

        public ActionResult Autorzy()
        {
            return View("Autorzy");
        }

        public ActionResult Detale_Autora(int id_a)
        {
            Autor a_d = db_A.Autorzy.Find(id_a); //autor_detale
            return View("Detale_Autora", a_d);
        }

        public ActionResult Edit_A(int id_a)
        {
            //db_A.Autorzy.AddOrUpdate(A);
            //db_A.SaveChanges();
            Autor a_e = db_A.Autorzy.Find(id_a);  //autor_edycja
                            //Autor ten_do_edycji = db_A.Autorzy.Find(id_a);
            return View("Edit_A", a_e);
            //return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit_A(Autor A)
        {
            db_A.Autorzy.AddOrUpdate(A);
            db_A.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete_A(int id_a)
        {
            Autor a_d = db_A.Autorzy.Find(id_a);   //autor_delete
            db_A.Autorzy.Remove(a_d);
            db_A.SaveChanges();
            //return View("Delete_A");
            return RedirectToAction("Index");

        }
    }
}
