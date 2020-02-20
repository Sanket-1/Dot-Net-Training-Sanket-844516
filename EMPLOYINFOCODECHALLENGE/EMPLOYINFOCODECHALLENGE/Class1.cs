
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYINFOCODECHALLENGE

{
    public abstract class Employ
    {
        public int id;
        public string first_name;
        public DateTime hire_date;
        public string last_name;
        public int salary;
        public virtual void display()
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("first_name:" + first_name);
            Console.WriteLine("hire_date:" + hire_date);
            Console.WriteLine("last_name:" + last_name);
            Console.WriteLine("salary:" + salary);
        }
    }

    public class Salesman : Employ
    {
        public decimal commission;
        public int target;
        public string zone;
        public override void display()
        {
            base.display();
            Console.WriteLine("commission:" + commission);
            Console.WriteLine("target:" + target);
            Console.WriteLine("zone:" + zone);
        }
    }
    public class Manager : Employ
    {
        public string curr_project;
        public int res_count;
        public override void display()
        {
            base.display();
            Console.WriteLine("curr_project:" + curr_project);
            Console.WriteLine("res_count" + res_count);
        }
    }
}

