using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DivisionController : Controller
    {
        MyContext myCon = new MyContext();
        // GET: Division
        public ActionResult Index()
        {
            var divisi = myCon.Divisions.Include("Department").ToList();
            return View(divisi.ToList());
        }
        
       
        // GET: Tests/Details/5
        public ActionResult Details(int id)
        {
            Division divisi = myCon.Divisions.Find(id);
            return View(divisi);
        }

        // GET: Tests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tests/Create
        [HttpPost]
        public ActionResult Create(Division division )
        {
            try
            {
                var input = myCon.Divisions.Add(division);
                myCon.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tests/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Division division)
        {
            try
            {
                var edit = myCon.Divisions.Find(id);
                edit.name = division.name;
                myCon.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tests/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}