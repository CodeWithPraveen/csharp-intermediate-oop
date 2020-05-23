using System;
using System.Collections.Generic;
using CMS.UI.Display;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetFullName();
            List<string> hobbies = student.Hobbies;

            Student student1 = new Student(10001, "Robert", "Smith");
            Console.WriteLine(student1.GetFullName());

            Console.WriteLine("Casting in Inheritance");
            Person person = new Student(10001, "David", "Smith");
            Console.WriteLine(person.GetFullName());

            Student student2 = person as Student;
            if (student2 != null)
            {
                 List<string> lstHobbies = student2.Hobbies;
            }

            if(person is Student)
            {
                // Refer Student members here.
                Student student3 = person as Student;
                List<string> lstHobbies = student3.Hobbies;
            }

            // Assignment1 Solution
            Person person2 = new Staff("Mary", "Smith");
            if(person2 is Staff)
            {
                Staff staff = person2 as Staff;
                Console.WriteLine(staff.WorkingHoursPerWeek);
            }
        }
    }
}
