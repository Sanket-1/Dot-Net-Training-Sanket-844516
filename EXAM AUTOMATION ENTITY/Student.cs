//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examautomation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public string seat_number { get; set; }
        public string student_name { get; set; }
        public System.DateTime exam_date { get; set; }
        public string exam_code { get; set; }
        public string center_code { get; set; }
    
        public virtual Center Center { get; set; }
        public virtual ExamDetail ExamDetail { get; set; }
    }
}
