//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crud1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Emp_Id { get; set; }
        public int Dept_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Nullable<int> Age { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
