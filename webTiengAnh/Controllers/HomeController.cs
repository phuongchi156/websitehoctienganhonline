using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DTO;
using webTiengAnh.Models.DAO;

namespace webTiengAnh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult KienThuc()
        {
            return View();
        }
        public ActionResult BaiHoc()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                var model = new BaiHocDAO().ListByGroupId();
                return View(model);
            }
        }
        public ActionResult DangKiHoc()
        {
            return View();
        }
        public ActionResult DangKi(HocSinhDTO hsa)
        {
            HocSinhDAo dao = new HocSinhDAo();
            dao.ThemHocSinh(hsa);
            return RedirectToAction("Index");
        }
        public ActionResult AddStd(HocSinhDTO hsa)
        {
            HocSinhDAo dao = new HocSinhDAo();
            dao.ThemHocSinh(hsa);
            SetViewBag();
            return RedirectToAction("Index");
        }
        public ActionResult ThongTinCaNhan(int id)
        {
            tienganhlop3s md = new tienganhlop3s();
            HocSinhDAo dt = new HocSinhDAo();
            var tan = dt.ListHocSinhID(id);
            ViewBag.ListKQ = md.KetQuas.Where(x => x.MaHS == id).ToList();
            return View(tan);
        }

        private void SetViewBag()
        {
            throw new NotImplementedException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}