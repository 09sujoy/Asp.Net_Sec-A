//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultationProject.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class patient
    {
        public int p_id { get; set; }
        public string p_sickreason { get; set; }
        public Nullable<int> u_id { get; set; }
    
        public virtual user user { get; set; }
    }
}
