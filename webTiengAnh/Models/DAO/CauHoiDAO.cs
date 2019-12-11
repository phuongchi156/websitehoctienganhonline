using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using webTiengAnh.Models.entity;
namespace webTiengAnh.Models.DAO
{
    public class CauHoiDAO
    {
        private tienganhlop3s  tn;
        public CauHoiDAO()
        {
            tn = new tienganhlop3s();
        }
        public List<CauHoi> ListQuiz()
        {
            var res = tn.CauHois.ToList();
            return res;
        }
        public IEnumerable<CauHoi> ListQuizPaging(int page, int pageSize)
        {
            return tn.CauHois.OrderByDescending(x => x.MaCH).ToPagedList(page, pageSize);
        }
        public int Insert(CauHoi entity)
        {
            tn.CauHois.Add(entity);
            tn.SaveChanges();
            return entity.MaCH;
        }
        public bool Update(CauHoi entity)
        {
            var qz = tn.CauHois.Find(entity.MaCH);
            qz.CauHoi1 = entity.CauHoi1;
            qz.Picture = entity.Picture;
            qz.A = entity.A;
            qz.B = entity.B;
            qz.C = entity.C;
            qz.D = entity.D;
            qz.DapAn = entity.DapAn;
            tn.SaveChanges();
            return true;
        }
        public void Delete(int id)
        {
            var tan = tn.CauHois.Find(id);
            tn.CauHois.Remove(tan);
            tn.SaveChanges();


        }
    }
}