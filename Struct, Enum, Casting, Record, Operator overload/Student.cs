using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Enum__Casting__Record__Operator_overload
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _Age;

        public int Age
        {
            get { return _Age; }
            set 
            { 
                if (value > 0 && value < 100)
                {
                    _Age = value;
                }
            }
        }

        public static bool operator >(Student stu1, Student stu2)
        {
            return stu1.Age > stu2.Age;
        }
        public static bool operator <(Student stu1, Student stu2)
        {
            return stu1.Age< stu2.Age;
        }
    }
}
