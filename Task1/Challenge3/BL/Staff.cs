using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Staff : Person
    {
        private string School;
        private double Pay;
        public Staff(string school, double pay, string name, string address) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }
        public string getSchool()
        {
            return this.School;
        }
        public double getPay()
        {
            return this.Pay;
        }
        public void setPay(double pay)
        { this.Pay = pay; }
        public void setSchool(string school)
        { this.School = school; }
        public new string toString()
        {
            return "Staff[" + base.toString() + ",school="+School+",Pay="+Pay+"]";
        }
    }
}
