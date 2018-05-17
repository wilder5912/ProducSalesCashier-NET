using store.Models;
using store.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace store.Controllers
{
    public class UserController : Controller
    {
        private UserService userService;

        public UserController()
        {
            userService = new UserService();
        }
        // GET: User
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult addUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addUser(UserMO userMO)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (var db = new storeEntities())
                {

                    db.user.Add(userService.getUser(userMO));
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", "error al agregar el alumno" + ex.Message);
                return View();

            }
        }

    }
}