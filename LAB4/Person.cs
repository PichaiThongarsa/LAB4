using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Grade { get; set; }
        public Person (string name, int year, double grade)

        {
            this.Name = name;
            this.Year = 2566-year;
            this.Grade = grade;
        }
       
    }
}
