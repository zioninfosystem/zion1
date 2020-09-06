using Apps.Common.DBContext;
using Apps.Common.DBEntities;
using Apps.Common.Helpers;
using Apps.Repository;
using LogisticProjects.Models;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LogisticProjects.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDataContext _db;
        private readonly UserRepository userRepo;

        public AccountController()
        {
            _db = new AppDataContext();
            userRepo = new UserRepository(_db);
        }

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new UserMaster() { EmailId = model.Email, Pwd = model.Password };
            user = userRepo.Authentication(user);

            if (user != null)
            {
                Session[Constants.USER_SESSION] = user;
                Session[Constants.USER_ID] = user.UserID;
                int timeout = model.RememberMe ? 525600 : 20;
                var ticket = new FormsAuthenticationTicket(user.UserName, model.RememberMe, timeout);
                string encrypted = FormsAuthentication.Encrypt(ticket);
                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                cookie.Expires = DateTime.Now.AddMinutes(timeout);
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);

                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
        }

        public ActionResult LogOff()
        {
            try
            {
                Session[Constants.USER_SESSION] = null;
                Session[Constants.USER_ID] = null;
                Session.Clear();
                Session.Abandon();
                FormsAuthentication.SignOut();
                return RedirectToAction("Login", "Account");
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Login", "Account");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_db != null)
                {
                    _db.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}