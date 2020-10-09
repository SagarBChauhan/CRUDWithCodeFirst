using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDWithCodeFirst.Models;

namespace CRUDWithCodeFirst.Controllers
{
    public class EmpController : Controller
    {
        //
        // GET: /Emp/
        EmployeeContext objContext = new EmployeeContext();
        public ActionResult Index()
        {
            return View(objContext.employee.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee objEmployee)
        {
            if (ModelState.IsValid)
            {
                objContext.employee.Add(objEmployee);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(objEmployee);
        }

        public ActionResult Edit(int EmployeeID)
        {
            return View(objContext.employee.Find(EmployeeID));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee objEmployee)
        {
            if (ModelState.IsValid)
            {
                objContext.Entry(objEmployee).State
                    = System.Data.EntityState.Modified;
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(objEmployee);
        }

        public ActionResult Delete(int EmployeeID)
        {
            return View(objContext.employee.Find(EmployeeID));
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult ConfirmDelete(int EmployeeID)
        {
            if (ModelState.IsValid)
            {
                Employee objEmp = objContext.employee.Find(EmployeeID);
                objContext.employee.Remove(objEmp);
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        public ActionResult Details(int EmployeeID)
        {
            return View(objContext.employee.Find(EmployeeID));
        }
    }
}
