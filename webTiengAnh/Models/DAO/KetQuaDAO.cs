using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;
using PagedList;

namespace webTiengAnh.Models.DAO
{
    public class KetQuaDAO
    {
        private tienganhlop3s tn;
        public KetQuaDAO()
        {
            tn = new tienganhlop3s();
        }
        public IEnumerable<KetQua> ListKetQua(int page, int pageSize)
        {
            return tn.KetQuas.OrderByDescending(x => x.MaKQ).ToPagedList(page, pageSize);
        }
        public void Delete(int id)
        {
            var tan = tn.KetQuas.Find(id);
            tn.KetQuas.Remove(tan);
            tn.SaveChanges();
        }
    }
}