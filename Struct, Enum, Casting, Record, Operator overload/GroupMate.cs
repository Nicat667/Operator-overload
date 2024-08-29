using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Enum__Casting__Record__Operator_overload
{
    internal class GroupMate
    {
        Student[] students = new Student[0];
        public void AddStudent(string name, string surname, int age)
        {
            Array.Resize(ref students, students.Length+1);
            Student student = new()
            {
                Name = name,
                Surname = surname,
                Age = age
            };
            students[students.Length-1] = student;
        }
        public void Sort()
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i+1; j < students.Length; j++)
                {
                    if (students[i] < students[j])
                    { 
                        Student x = students[i];
                        students[i] = students[j];
                        students[j] = x;
                    }
                    
                }
            }
        }
        public void ShowStudents()
        {
            Sort();
            int number = 1;
            foreach (Student student in students)
            {
                Console.WriteLine($"{number}) {student.Name} {student.Surname} {student.Age}");
                number++;
            }
        }
    }
}
