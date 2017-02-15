using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using pc_internship.Models;
using PagedList;
using System.IO;

namespace pc_internship.Controllers
{
    public class EmployeeModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EmployeeModels
        public ActionResult Index(string currentFilter, string searchString,  int? page)
        {
            if(searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;
            var employees = from e in db.Employees select e;
            if(!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e => e.EmployeeName.Contains(searchString)
                               || e.EmployeeLastName.Contains(searchString));
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(employees.OrderBy(e => e.EmployeeNetSalary).ToPagedList(pageNumber, pageSize));
        }

        // GET: EmployeeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeModel employeeModel = db.Employees.Find(id);
            if (employeeModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeModel);
        }

        // GET: EmployeeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,EmployeeName,EmployeeLastName,EmployeeNetSalary,ImgPath")] EmployeeModel employeeModel, HttpPostedFileBase file)
        {
            if(file != null)
            {
                string picture = Path.GetFileName(file.FileName);
                string filePath = Path.Combine(Server.MapPath("~/Uploads/EmployeePhotos"), picture);
                file.SaveAs(filePath);
                employeeModel.ImgPath = "~/Uploads/EmployeePhotos/" + picture;
            }
            if (ModelState.IsValid)
            {
                db.Employees.Add(employeeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeModel);
        }

        // GET: EmployeeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeModel employeeModel = db.Employees.Find(id);
            if (employeeModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeModel);
        }

        // POST: EmployeeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,EmployeeName,EmployeeLastName,EmployeeNetSalary,ImgPath")] EmployeeModel employeeModel, HttpPostedFileBase file)
        {
            if (file != null)
            {
                string picture = Path.GetFileName(file.FileName);
                string filePath = Path.Combine(Server.MapPath("~/Uploads/EmployeePhotos"), picture);
                file.SaveAs(filePath);
                employeeModel.ImgPath = "~/Uploads/EmployeePhotos/" + picture;
            }
            if (ModelState.IsValid)
            {
                db.Entry(employeeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit");
            }
            return View(employeeModel);
        }

        // GET: EmployeeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeModel employeeModel = db.Employees.Find(id);
            if (employeeModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeModel);
        }

        // POST: EmployeeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeModel employeeModel = db.Employees.Find(id);
            db.Employees.Remove(employeeModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
