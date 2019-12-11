using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DAO;
using webTiengAnh.Models.DTO;
using PagedList;

namespace webTiengAnh.Controllers
{
    public class BaiHocController : Controller
    {
        // GET: BaiHoc
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult QLBaiHoc(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                BaiHocDAO dao = new BaiHocDAO();
                IQueryable<BaiHoc> hs = dao.DanhSachBaiHoc();
                return View(hs.OrderBy(n => n.MaBH).ToPagedList(pageNumber, pageSize));
            }
        }
        public ActionResult SearchBaiHoc()
        {
            return View();
        }


        public ActionResult ThemBaiHoc()
        {
            return View();
        }
        public ActionResult AddBaiHoc(BaiHocDTO hsa)
        {
            BaiHocDAO dao = new BaiHocDAO();
            dao.ThemBH(hsa);
            return RedirectToAction("QLBaiHoc");
        }
        public ActionResult SuaBaiHoc(int id)
        {
            BaiHocDAO dao = new BaiHocDAO();
            BaiHoc bh = dao.FindBaiHocById(id);
            return View(bh);
        }
        public ActionResult EditActionBaiHoc(BaiHoc hsu)
        {
            BaiHocDAO dao = new BaiHocDAO();

            dao.SuaBH(hsu);
            return RedirectToAction("QLBaiHoc");
        }
        public ActionResult XoaBaiHoc(int id)
        {
            BaiHocDAO dao = new BaiHocDAO();
            //BaiHoc bh = dao.FindBaiHocById(id);
            dao.XoaBH(id);

            return RedirectToAction("QLBaiHoc");
        }
        public ActionResult ChiTietBH(int id)
        {
            
            var model = new BaiHocDAO().ListBHID(id);
            return View(model);
        }
        public JsonResult KiemTraNghia(string txt1, string txt2)
        {
            BaiHoc bh = new BaiHoc();
            //bh.NghiaTu = 
            BaiHocDAO dao = new BaiHocDAO();
            var kq = dao.Kiemtra(txt1, txt2);
            //kq = BaiHocDAO().Kiemtra(txt1, txt2);
            if (kq == 1)
            {
                return Json(new { status = true });
            }
            else
                return Json(new { status = false });
        }
    }
}