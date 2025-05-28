using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide5
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Grade { get; set; }
        public Student(int id, string name, float grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
    }


}
