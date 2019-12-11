using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTiengAnh.Models.DTO
{
    public class BaiHocDTO
    {
        public int MaBH { get; set; }
        public string TenBH { get; set; }
        public string ChuDe { get; set; }
        public string AnhChuDe { get; set; }
        public string NoiDung { get; set; }
        public string NoiDungAnh { get; set; }
        public string NghiaTu { get; set; }
        public string NghiaTu2 { get; set; }
    }
}