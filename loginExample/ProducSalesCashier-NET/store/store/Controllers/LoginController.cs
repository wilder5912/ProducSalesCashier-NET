using Helper;
using store.Models;
using store.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace store.Controllers
{
    public class LoginController : Controller
    {

        private UserService userService;

        public LoginController()
        {
            userService = new UserService();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserMO userMO)
        {
            UserMO userCurrent = new UserMO();
            userCurrent = userService.getUserInformation(userMO);

            if (null != userCurrent) {

                int Usuario_id = (int)userCurrent.userId;
                SessionHelper.AddUserToSession(userCurrent.userId + "");
               // SessionHelper.AddUserToSession(userCurrent.EmailUser+ "");

                return Redirect("~/Home");
            }
           ModelState.AddModelError("", "error en el usuario");
            return View();

        }

        [HttpPost]
        public ActionResult Autentificar(UserMO userMO)
        {
            // Guardamos un usuario en SESSION, en teoría tiene el ID número 2001
            int Usuario_id = 2001;

            SessionHelper.AddUserToSession(Usuario_id.ToString());

            return Redirect("~/Home");
        }


        public ActionResult Autentificado()
        {
            return View();
        }

        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
            return Redirect("~/Login");
        }

    }
}