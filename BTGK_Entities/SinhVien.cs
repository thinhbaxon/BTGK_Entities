//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTGK_Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SinhVien
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> ID_Lop { get; set; }
    
        public virtual LopSV LopSV { get; set; }
    }
}
