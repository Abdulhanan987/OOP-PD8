using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Person
    {
        protected string Name;
        protected string Address;
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public void setAddress(string address)
        {
            this.Address = address;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getAddress()
        {
            return this.Address;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string toString()
        {
            return "Person[name=" + Name + ", address" + Address + "]";
        }
    }
}
