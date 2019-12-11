using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.DAO;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DTO;

namespace webTiengAnh.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAction(HocSinh account)
        {
            if (ModelState.IsValid)
            {
                UserDAo dao = new UserDAo();
                int check = dao.Login(account.UserName, account.PassWord);
                if (check == 1)
                {
                    //var admin = dao.getadmin(account.MaHS);
                    //var accSession = new AdminDTO();
                    //accSession.TenDNAD = admin.TenDNAD;
                    //accSession.MaAD = admin.MaAD;
                    
                    Session["UserName"] = account;
                    
                    //Session.Add(Contect.admin_session, accSession);
                    return RedirectToAction("Admin", "HocSinh");
                }
                else if (check == 2)
                {
                    //var admin = dao.gethocsinh(account.MaHS);
                    //var accSession = new HocSinhDTO();
                    //accSession.UserName = admin.UserName;
                    //accSession.MaHS = admin.MaHS;
                    var idHS = dao.getIDbyUsername(account.UserName).MaHS;
                    Session["UserName"] = account;
                    Session["MaHS"] = idHS;
                    //Session.Add(Contect.user_session, accSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            return RedirectToAction("Login", "Login");
        }
        public ActionResult Logout()
        {
            Session["UserName"] = null;
            Session["MaHS"] = null;
            return View("Login");
        }
    }
}