using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;

namespace webTiengAnh.Models.DTO
{
    public class KiemTraDTO
    {
        public int MaDe { get; set; }
        public List<DeThi> ListDeThi()
        {
            tienganhlop3s tn = new tienganhlop3s();
            var model = tn.DeThis.ToList();
            return model;
        }
    }
}