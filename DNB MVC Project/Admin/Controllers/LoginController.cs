using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL_DNB;
using Model_DNB;

namespace Admin.Controllers
{
    public class LoginController : Controller
    {
        BAL_EncryptDecrypt bal_EncryptDecrypt = new BAL_EncryptDecrypt();
        BAL_user bal_user = new BAL_user();
        Model_User Model_User new Model_User(); 
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(String username, String password)
        {
            try
            {
                password = bal_EncryptDecrypt.Encrypt(password);


            }
            catch (Exception ex) { }
            return Json(Model_User, JsonRequestBehavior.AllowGet);
        }
            // GET: Login/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
