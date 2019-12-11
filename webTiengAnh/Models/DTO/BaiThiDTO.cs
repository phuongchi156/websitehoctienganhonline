using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webTiengAnh.Models.entity;

namespace webTiengAnh.Models.DTO
{
    public class BaiThiDTO
    {
         public List<ch_db> ListQuiz { get; set; }
         public int? Time { get; set; }
    }
}