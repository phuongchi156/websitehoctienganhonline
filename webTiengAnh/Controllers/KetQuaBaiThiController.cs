using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DAO;

namespace webTiengAnh.Controllers
{
    public class KetQuaBaiThiController : Controller
    {
        // GET: KetQuaBaiThi
        BaiThiDAO cd = new BaiThiDAO();
        tienganhlop3s md = new tienganhlop3s();
        public ActionResult Index(int maThiSinh, int maDe)
        {
            var tan = cd.ListKetQuaID(maThiSinh, maDe);
            return View(tan);
        }
    }
}