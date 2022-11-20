using EkpaideftikoLogismikoWeb.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkpaideftikoLogismikoWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            NameValueCollection formData = Request.Form;
            User user = new DataAccess().AuthenticateUser(formData["username"], formData["password"]);
            if (user != null)
            {
                HttpCookie cookie = new HttpCookie("username");
                cookie.Values.Add("username", formData["username"]);
                cookie.Expires = DateTime.Now.AddHours(12);
                Response.Cookies.Add(cookie);
            }
            //return View("../Home/Index");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            if (Request.Cookies["username"] != null)
            {
                Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}