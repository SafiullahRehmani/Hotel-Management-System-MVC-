//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees_Contact_No_s
    {
        public int ECID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public Nullable<long> Employee_Contact_No_s { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
    }
}
