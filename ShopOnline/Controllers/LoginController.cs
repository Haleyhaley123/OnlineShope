using ShopOnline.Code;
using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]// server sinh ra token và client có 1 token, 2 token tương ứng với nhau
        public ActionResult Login(LoginModels model)
        {
           if(model.Username == "halt63" && model.Password == "1234")
            {
                SessionHelper.SetSession(new UserSession() { UserName = model.Username });
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không chính xác");
            }
           
            return View(model);
        }
    }
}