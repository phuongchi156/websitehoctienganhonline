using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DTO;
using webTiengAnh.Models.DAO;
using PagedList;

namespace webTiengAnh.Controllers
{
    public class HocSinhController : Controller
    {
        // GET: HocSinh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Admin()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                return View();
            }
        }
        public ActionResult QLHocSinh(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                HocSinhDAo dao = new HocSinhDAo();
                IQueryable<HocSinh> hs = dao.DanhSachHS();
                return View(hs.OrderBy(n => n.MaHS).ToPagedList(pageNumber, pageSize));
            }
        }
        public ActionResult SearchStudent()
        {
            return View();
        }
        

        public ActionResult ThemHocSinh()
        {
            return View();
        }
        public ActionResult AddStd(HocSinhDTO hsa)
        {
            HocSinhDAo dao = new HocSinhDAo();
            dao.ThemHocSinh(hsa);
            return RedirectToAction("QLHocSinh");
        }
        public ActionResult SuaHocSinh(int id)
        {
            HocSinhDAo dao = new HocSinhDAo();
            HocSinh hs = dao.FindStudentById(id);
            return View(hs);
        }
        public ActionResult EditActionStd(HocSinh hsu)
        {
            HocSinhDAo dao = new HocSinhDAo();

            dao.SuaHocSinh(hsu);
            return RedirectToAction("QLHocSinh");
        }
        public ActionResult XoaHocSinh(int id)
        {
            HocSinhDAo dao = new HocSinhDAo();
            //HocSinh hs = dao.FindStudentById(id);
            dao.XoaHocSinh(id);

            return RedirectToAction("QLHocSinh");
        }

    }
}