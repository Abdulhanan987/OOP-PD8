using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Student:Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string program, int year, double fee, string name, string address) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public string getProgram()
            {
            return this.Program;
        }
        public int getYear()
        {
            return this.Year;
        }
        public double getFee()
        {
            return this.Fee;
        }
        public void setProgram(string program)
        { this.Program = program; }
        public void setYear(int year)
        { this.Year = year; }
        public void setFee(double fee)
        { this.Fee = fee; }
        public new string toString()
        {
            return "Student["+base.toString()+",program ="+Program+",Year= "+Year+",Fee="+Fee+"]";
        }
    }
}
