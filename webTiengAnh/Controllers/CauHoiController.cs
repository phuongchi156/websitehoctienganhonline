using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webTiengAnh.Models.DAO;
using webTiengAnh.Models.entity;
using PagedList;
using System.IO;

namespace webTiengAnh.Controllers
{
    public class CauHoiController : Controller
    {
        // GET: CauHoi
        tienganhlop3s tn = new tienganhlop3s();
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            CauHoiDAO qz = new CauHoiDAO();
            var model = qz.ListQuizPaging(page, pageSize);
            return View(model);
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CauHoi collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    byte[] imageData = null;
                    if (Request.Files.Count > 0)
                    {
                        HttpPostedFileBase poImgFile = Request.Files["fileim"];
                        using (var binary = new BinaryReader(poImgFile.InputStream))
                        {
                            imageData = binary.ReadBytes(poImgFile.ContentLength);
                        }
                    }
                    collection.Picture = imageData;
                    var qz = new CauHoiDAO();
                    int id = qz.Insert(collection);
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "CauHoi");
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
			var model = tn.CauHois.Find(id);
            return View(model);
        }

        // POST: Admin/Quiz/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CauHoi collection)
        {
            try
            {
				// TODO: Add update logic here
				if (ModelState.IsValid)
				{
					byte[] imageData = null;
					HttpPostedFileBase poImgFile = Request.Files["fileim"];
					if (poImgFile != null && poImgFile.ContentLength > 0)
					{
						using (var binary = new BinaryReader(poImgFile.InputStream))
						{
							imageData = binary.ReadBytes(poImgFile.ContentLength);
						}
						collection.Picture = imageData;
						var ts = new CauHoiDAO();
						var res = ts.Update(collection);
						if (res)
						{
							return RedirectToAction("Index", "CauHoi");
						}
						else
						{
							ModelState.AddModelError("", "Sửa thất bại");
						}
					}
					else
					{
						byte[] tana = tn.CauHois.Where(x => x.MaCH == id).Select(u => u.Picture).SingleOrDefault();
						collection.Picture = tana;
						var ts = new CauHoiDAO();
						var res = ts.Update(collection);
						if (res)
						{
							return RedirectToAction("Index", "CauHoi");
						}
						else
						{
							ModelState.AddModelError("", "Sửa thất bại");
						}
					}
				}
				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            CauHoiDAO dao = new CauHoiDAO();
            //HocSinh hs = dao.FindStudentById(id);
            dao.Delete(id);

            return RedirectToAction("Index");
        }
    }
}