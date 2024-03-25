using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("CS",4,33000.33,"Abdul Hanan","Lahore");
            Console.WriteLine(student.toString());
            Console.WriteLine(student.getProgram());
            Console.WriteLine(student.getYear());
            Console.WriteLine(student.getFee());
            Console.WriteLine(student.getAddress());
            Console.WriteLine(student.getName());
            Staff staff = new Staff("UET", 10000, "Ali", "Lahore");
            Console.WriteLine(staff.toString());
            Console.WriteLine(staff.getAddress());
            Console.WriteLine(staff.getName());
            Console.WriteLine(staff.getSchool());
            Console.WriteLine(staff.getPay());
            Console.ReadKey();
        }
    }
}
