using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DTO;

namespace webTiengAnh.Models.DAO
{
    public class BaiHocDAO
    {
        private tienganhlop3s md;
        public BaiHocDAO()
        {
            md = new tienganhlop3s();
        }
        public List<BaiHoc> ListByGroupId()
        {
            return md.BaiHocs.ToList();
        }
        public List<BaiHoc> ListBHID(int maBH)
        {
            var res = md.BaiHocs.Where(x => x.MaBH == maBH).ToList();
            return res;
        }
        public IQueryable<BaiHoc> DanhSachBaiHoc()
        {
            var rs = (from hs in md.BaiHocs
                      select hs);
            return rs;
        }
        public int ThemBH(BaiHocDTO hsa)
        {
            BaiHoc bh = new BaiHoc();
            bh.MaBH = hsa.MaBH;
            bh.TenBH = hsa.TenBH;
            bh.ChuDe = hsa.ChuDe;
            bh.AnhChuDe = hsa.AnhChuDe;
            bh.NoiDung = hsa.NoiDung;
            bh.NoiDungAnh = hsa.NoiDungAnh;
            bh.NghiaTu = hsa.NghiaTu;
            bh.NghiaTu2 = hsa.NghiaTu2;
            md.BaiHocs.Add(bh);
            md.SaveChanges();

            return bh.MaBH;
        }
        public int SuaBH(BaiHoc hsu)
        {
            BaiHoc bh = md.BaiHocs.Find(hsu.MaBH);
            if (bh != null)
            {
                bh.TenBH = hsu.TenBH;
                bh.ChuDe = hsu.ChuDe;
                bh.AnhChuDe = hsu.AnhChuDe;
                bh.NoiDung = hsu.NoiDung;
                bh.NoiDungAnh = hsu.NoiDungAnh;
                bh.NghiaTu = hsu.NghiaTu;
                bh.NghiaTu2 = hsu.NghiaTu2;
                md.SaveChanges();
            }
            return bh.MaBH;
        }
        public void XoaBH(int id)
        {
            var baihoc = md.BaiHocs.Find(id);
            md.BaiHocs.Remove(baihoc);
            md.SaveChanges();
        }
        public BaiHoc FindBaiHocById(int id)
        {
            return md.BaiHocs.Find(id);
        }
        public IQueryable<BaiHoc> SearchBaiHoc(string com)
        {
            var rs = (from hs in md.BaiHocs
                      where hs.TenBH.Contains(com)
                      select hs);
            return rs;
        }
        public int Kiemtra(string txt1, string txt2)
        {
            var noidung1 = md.BaiHocs.Count(x => x.NghiaTu == txt1);
            var noidung2 = md.BaiHocs.Count(x => x.NghiaTu2 == txt2);
            if (noidung1 > 0 || noidung2 > 0)
            {
                return 1;
            }
            else return 0;
        }
    }
}