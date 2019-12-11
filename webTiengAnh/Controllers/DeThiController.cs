using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.DAO;
using webTiengAnh.Models.entity;
using System.IO;

namespace webTiengAnh.Controllers
{
    public class DeThiController : Controller
    {
        // GET: DeThi
        public ActionResult Index()
        {
            DeThiDAO dt = new DeThiDAO();
            var model = dt.ListDeThi();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            DeThiDAO dt = new DeThiDAO();
            var model = dt.ListQuizID(id);
            SetViewBagDD();
            return View(model);
        }
        public void SetViewBagDD(int? selectedID = null)
        {
            var qz = new CauHoiDAO();
            ViewBag.MaCh = new SelectList(qz.ListQuiz(), "MaCH", "CauHoi1", selectedID);
        }
        public void SetViewBagMD(int selectedID)
        {

            var db = new DeThiDAO();
            ViewBag.MaDe = new SelectList(db.ListDeThi(), "MaDe", "MoTa", selectedID);
        }
        public ActionResult Create(DeThi collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    //collection.NgayTao = DateTime.Now;
                    DeThiDAO tan = new DeThiDAO();
                    int id = tan.Insert(collection);
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "DeThi");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm thất bại");
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            DeThiDAO dao = new DeThiDAO();
            DeThi model = dao.FindDeThiById(id);
            SetViewBagDD();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult EditActionDT(DeThi hsu)
        {
            DeThiDAO dao = new DeThiDAO();

            dao.Update(hsu);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            DeThiDAO dao = new DeThiDAO();
            dao.Delete(id);
            return RedirectToAction("Index");
        }


    // POST: Admin/DeThi/Delete/5
    public ActionResult AddQuiz(int id)
        {
            SetViewBagDD();
            SetViewBagMD(id);
            return View();
        }
        [HttpPost]
        public ActionResult AddQuiz(ch_db collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DeThiDAO tan = new DeThiDAO();
                    int id = tan.InsertID(collection);
                    if (id > 0)
                    {
                        return RedirectToAction("Details/" + Url.RequestContext.RouteData.Values["ID"], "DeThi");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm thất bại");
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult XoaCauHoiAdd(int id)
        {
            tienganhlop3s tn = new tienganhlop3s();
            var model = tn.ch_db.Find(id);
            BaiThiDAO thd = new BaiThiDAO();
            thd.DeleteCauHoiAdd(id);
            return RedirectToAction("Details");
        }
        //public ActionResult RemoveQuizInTheardID(int id)
        //{
        //    tienganhlop3 tn = new tienganhlop3();
        //    var model = tn.ch_db.Find(id);
        //    BaiThiDAO thd = new BaiThiDAO();
        //    thd.DeleteQuizInTheard(id);
        //    return View(model);
        //}
        //[HttpDelete]
        //public ActionResult RemoveQuizInTheardID(int id, FormCollection collection, int theard)
        //{
        //      BaiThiDAO thd = new BaiThiDAO();
        //      thd.DeleteQuizInTheard(id);
        //      return RedirectToAction("Details", "DeThi", new { id = theard });
        //    //    if (ModelState.IsValid)
        //    //    {
        //    //        var res = thd.DeleteQuizInTheard(id);
        //    //        if (res)
        //    //        {
        //    //            return RedirectToAction("Details", "DeThi", new { id = theard });
        //    //        }
        //    //        else
        //    //        {
        //    //            ModelState.AddModelError("", "Xóa thất bại");
        //    //        }
        //    //    }
        //    //    return RedirectToAction("Index");
        //    //}
        //    //catch
        //    //{
        //    //    return View();
        //    //}
        //}
    }
}