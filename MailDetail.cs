//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mail
{
    using System;
    using System.Collections.Generic;
    
    public partial class MailDetail
    {
        public int MailID { get; set; }
        public int UserID { get; set; }
        public string MailForm { get; set; }
        public string Subject1 { get; set; }
        public System.DateTime ReceiveDate { get; set; }
        public string Messsage { get; set; }
    
        public virtual MAIL MAIL { get; set; }
    }
}
