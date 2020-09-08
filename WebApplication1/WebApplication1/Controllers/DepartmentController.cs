using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        MyContext myCon = new MyContext();
        // GET: Department
        public ActionResult Index()
        {
            return View(myCon.Departments.ToList());
        }
        
        // GET: Tests/Details/5
        public ActionResult Details(int id)
        {
            return View(myCon.Departments.Find(id));
        }

        // GET: Tests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tests/Create
        [HttpPost]
        public ActionResult Create(Department department)
        {
            try
            {
                // TODO: Add insert logic here
                var input = myCon.Departments.Add(department);
                myCon.SaveChanges();
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
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                // TODO: Add update logic here
                var edit = myCon.Departments.Find(id);
                edit.name = department.name;
                myCon.SaveChanges();

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
        public ActionResult Delete(int id, Department department)
        {
            try
            {
                var delete = myCon.Departments.Find(id);
                myCon.Departments.Remove(delete);
                myCon.SaveChanges();
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