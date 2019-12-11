using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;

namespace webTiengAnh.Models.DAO
{
    public class DeThiDAO
    {
        private tienganhlop3s tn;
        public DeThiDAO()
        {
            tn = new tienganhlop3s();
        }
        public List<DeThi> ListDeThi()
        {
            var res = tn.DeThis.ToList();
            return res;
        }
        public List<ch_db> ListQuizID(int MaDe)
        {
            var res = tn.ch_db.Where(x => x.MaDe == MaDe).ToList();
            return res;
        }
        public List<CauHoi> ListChID(int MaCH)
        {
            var res = tn.CauHois.Where(x => x.MaCH == MaCH).ToList();
            return res;
        }
        public int Insert(DeThi entity)
        {
            tn.DeThis.Add(entity);
            tn.SaveChanges();
            return entity.MaDe;
        }
        public int Update(DeThi hsu)
        {
            DeThi hs = tn.DeThis.Find(hsu.MaDe);
            if (hs != null)
            {
                hs.MoTa = hsu.MoTa;
                hs.TrangThai = true;
                hs.ThoiGian = hsu.ThoiGian;
                hs.SoCauHoi = hsu.SoCauHoi;
                tn.SaveChanges();
            }
            return hs.MaDe;
        }
        public void Delete(int id)
        {
                var tan = tn.DeThis.Find(id);
                tn.DeThis.Remove(tan);
                tn.SaveChanges();
        }
        public int InsertID(ch_db entity)
        {
            tn.ch_db.Add(entity);
            tn.SaveChanges();
            return entity.ID;
        }
        public DeThi FindDeThiById(int id)
        {
            return tn.DeThis.Find(id);
        }
    }
}