using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTiengAnh.Models.DTO
{
    public class HocSinhDTO
    {
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }

        public string PhuHuynh { get; set; }

        public string DiaChi { get; set; }

        public string SDT { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}