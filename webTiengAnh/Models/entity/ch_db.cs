//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webTiengAnh.Models.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ch_db
    {
        public int ID { get; set; }
        public Nullable<int> MaCH { get; set; }
        public Nullable<int> MaDe { get; set; }
        public string GhiChu { get; set; }
    
        public virtual CauHoi CauHoi { get; set; }
        public virtual DeThi DeThi { get; set; }
    }
}
