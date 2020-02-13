using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient; 

namespace adddatatosql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_Click1(object sender, EventArgs e)
        {
            ASSESMENTEntities ctx = new ASSESMENTEntities();
            WEBAPP db = new WEBAPP();
            db.FirstName = fn.Text;
            db.Age = int.Parse(age.Text);
            db.LastName = lastn.Text;
            db.LoginName = log.Text;
            db.Password1 = pass.Text;
            db.Experience = int.Parse(exp.Text);
            db.Salary = int.Parse(sal.Text);
            ctx.WEBAPPs.Add(db);
            ctx.SaveChanges();
        }
    }
}