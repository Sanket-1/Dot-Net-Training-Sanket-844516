using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mail.Models
{
    public class InboxViewModel
    {
        public List<MailDetail> mlist = new List<MailDetail>();

    }
    public class MAilDetails
    {
        
            public int MailID;
            public string MailForm;
            public string Subject1;
            public DateTime ReceiveDate;
            public string Messsage;
    }
}