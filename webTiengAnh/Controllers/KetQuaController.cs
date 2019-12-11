using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DAO;
using PagedList;

namespace webTiengAnh.Controllers
{
    public class KetQuaController : Controller
    {
        // GET: KetQua
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            KetQuaDAO qk = new KetQuaDAO();
            var model = qk.ListKetQua(page, pageSize);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            KetQuaDAO dao = new KetQuaDAO();
            dao.Delete(id);

            return RedirectToAction("Index");
        }
    }
}