using Library.BLL.Services;
using Library.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Library.Controllers
{
    public class UserController : Controller
    {
        UserService userService;
        public UserController()
        {
            userService = new UserService();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUserViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (userService.isUserCorrect(model))
                {
                    FormsAuthentication.SetAuthCookie(model.Name, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Publication", "Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Uncorrect Login or Password");
                }
            }
            return View(model);
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(CreateUserViewModel user)
        {
            try
            {
                if(userService.isLoginUnoccupied(user.Name))
                {
                    userService.Create(user);

                    return RedirectToAction("Publications", "Index");
                }
                else
                {
                    ModelState.AddModelError("", "This login already occupied");
                    return View(user);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
