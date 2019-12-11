using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;
using webTiengAnh.Models.DTO;

namespace webTiengAnh.Models.DAO
{
    public class HocSinhDAo
    {
        tienganhlop3s md;
        public HocSinhDAo()
        {
            md = new tienganhlop3s();
        }
        public IQueryable<HocSinh> DanhSachHS()
        {
            var rs = (from hs in md.HocSinhs
                      select hs);
            return rs;
        }
        public List<HocSinh> ListHocSinhID(int id)
        {
            var tan = md.HocSinhs.Where(x => x.MaHS == id);
            return tan.ToList();
        }
        public int ThemHocSinh(HocSinhDTO hsa)
        {
            HocSinh hs = new HocSinh();
            //Hoc h = new Hoc();
            //LopHoc rs = (from lh in md.LopHocs
            // where lh.KhoaHocID == hsa.KhoaHocID
            //select lh).ToList().ElementAt(0);
            //int a = rs.LopHocID;
            hs.MaHS = hsa.MaHS;
            hs.TenHS = hsa.TenHS;
            hs.NgaySinh = hsa.NgaySinh;
            hs.GioiTinh = hsa.GioiTinh;
            hs.DiaChi = hsa.DiaChi;
            hs.PhuHuynh = hsa.PhuHuynh;
            hs.SDT = hsa.SDT;
            hs.UserName = hsa.UserName;
            hs.PassWord = hsa.PassWord;
            // h.LopHocID = a;
            //h.HocSinhID = hsa.HocSinhID;
            //md.HocSinhs.Add(hs);
            //md.Hocs.Add(h);
            md.HocSinhs.Add(hs);
            md.SaveChanges();

            return hs.MaHS;
        }
        public int SuaHocSinh(HocSinh hsu)
        {
            HocSinh hs = md.HocSinhs.Find(hsu.MaHS);
            if (hs != null)
            {
                hs.TenHS = hsu.TenHS;
                hs.NgaySinh = hsu.NgaySinh;
                hs.GioiTinh = hsu.GioiTinh;
                hs.DiaChi = hsu.DiaChi;
                hs.PhuHuynh = hsu.PhuHuynh;
                hs.SDT = hsu.SDT;
                md.SaveChanges();
            }
            return hs.MaHS;
        }
        public void XoaHocSinh(int id)
        {
            var hocsinh = md.HocSinhs.Find(id);
            md.HocSinhs.Remove(hocsinh);
            md.SaveChanges();
        }
        public HocSinh FindStudentById(int id)
        {
            return md.HocSinhs.Find(id);
        }
        public IQueryable<HocSinh> SearchStudent(string com)
        {
            var rs = (from hs in md.HocSinhs
                      where hs.TenHS.Contains(com)
                      select hs);
            return rs;


        }
    }
}