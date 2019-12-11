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
    public class DefaultController : Controller
    {
        // GET: Default
        DeThiDAO dt = new DeThiDAO();
        tienganhlop3s tn = new tienganhlop3s();
        //public string SelectedAnswer { get; set; }
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            else
            {
                var tan = dt.ListDeThi();
                return View(tan);
            }

        }
        public ActionResult StartContest(int id)
        {
            BaiThiDTO cm = new BaiThiDTO();
            cm.ListQuiz = tn.ch_db.Where(x => x.MaDe == id).ToList();
            cm.Time = tn.DeThis.Where(x => x.MaDe == id).Select(u => u.ThoiGian).FirstOrDefault();
            return View(cm);
        }
        [HttpPost]
        public ActionResult StartContest(int id, BaiThiDTO collection)
        {
            int socau = tn.ch_db.Count(x => x.MaDe == id);
            float hesodiem = 100 / socau;
            float diem;
            int bodem = 0;
            for (int i = 0; i < collection.ListQuiz.Count; i++)
            {
                var quizid = tn.CauHois.Find(collection.ListQuiz[i].MaCH);
                if (quizid.DapAn == collection.ListQuiz[i].GhiChu)
                {
                    bodem = bodem + 1;
                }
            }
            diem = bodem * hesodiem;
            int session = int.Parse(Session["MaHS"].ToString());
            //var session = (TracNghiemLTK.Common.ThiSinhInfo)Session[TracNghiemLTK.Common.CommonConstantsStudent.STUDENT_SESSION];
            //var ma = tn.KetQuas;
            tn.KetQuas.Add(new KetQua()
            {
                MaDe = id,
                MaHS = session,
                Diem = diem,
                NgayThi = DateTime.Now
            });
            tn.SaveChanges();
            return RedirectToAction("Index", "KetQuaBaiThi", new { @maThiSinh = Session["MaHS"], @maDe = id });
            //return RedirectToAction("Index", "KetQuaBaiThi", new { @maDe = id });

        }

    }
}