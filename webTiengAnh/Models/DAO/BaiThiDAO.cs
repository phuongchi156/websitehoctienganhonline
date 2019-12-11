using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;

namespace webTiengAnh.Models.DAO
{
    
    public class BaiThiDAO
    {
        private tienganhlop3s md;
        public BaiThiDAO()
        {
            md = new tienganhlop3s();
        }
        public List<ch_db> ListQuiz()
        {
            var model = md.ch_db.ToList();
            return model;
        }
        public bool CheckQuiz(int maCauHoi, string dapAn)
        {
            var model = md.CauHois.Count(x => x.MaCH == maCauHoi && x.DapAn == dapAn);
            if (model > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteCauHoiAdd(int id)
        {
            var tan = md.ch_db.Select(x => x.MaCH == id);
            var ten = md.ch_db.Find(tan);
            md.ch_db.Remove(ten);
            md.SaveChanges();
        }
        public List<KetQua> ListKetQuaID(int maThiSinh, int maDe)
        {
            var tan = md.KetQuas.Where(x => x.MaDe == maDe && x.MaHS == maThiSinh).ToList();
            return tan;
        }
        //public void DeleteQuizInTheard(int id)
        //{
        //    var tan = md.ch_db.Find(id);
        //    md.ch_db.Remove(tan);
        //    md.SaveChanges();
        //}
    }
}