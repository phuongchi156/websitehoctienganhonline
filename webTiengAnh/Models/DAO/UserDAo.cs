using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;

namespace webTiengAnh.Models.DAO
{
    public class UserDAo
    {
        tienganhlop3s mymd = null;
        public UserDAo()
        {
            mymd = new tienganhlop3s();
        }
        public long Insert(HocSinh entity)
        {
            mymd.HocSinhs.Add(entity);
            mymd.SaveChanges();
            return entity.MaHS;
        }
        public int Login(string username, string password)
        {
            var ad = mymd.ADMINs.Count(x => x.TenDNAD == username && x.PassAD == password);
            var rs = mymd.HocSinhs.Count(x => x.UserName == username && x.PassWord == password);
            
            if (rs > 0 || ad > 0)
            {
                if (rs > 0 && ad == 0)
                {
                    return 2;
                }
                else
                    return 1;

            }
            else
                return 0;
        }
        public HocSinh gethocsinh(int id)
        {
            return mymd.HocSinhs.Find(id);
        }
        public ADMIN getadmin(int id)
        {
            return mymd.ADMINs.Find(id);
        }
        public HocSinh getIDbyUsername(string userName)
        {
            return mymd.HocSinhs.FirstOrDefault(x => x.UserName == userName);
        }
    }
}