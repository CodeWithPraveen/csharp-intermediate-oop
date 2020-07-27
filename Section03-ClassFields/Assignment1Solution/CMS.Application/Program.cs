using System;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object instantiation
            Student student = new Student();
            Staff staff = new Staff();

            Course computerScience = new Course();
            computerScience.CourseId = 201;
            computerScience.CourseName = "ComputerScience";
            Console.WriteLine(computerScience.CourseId);
            Console.WriteLine(computerScience.CourseName);
            
            // Field assignment
            student.FirstName = "John";
            Console.WriteLine(student.FirstName);

            // Direct initialization
            Student student2 = new Student()
            {
                FirstName = "John",
                LastName = "McCarter",
                StudentId = 10001
            };

            // readonly variable
            //student2.MaxEnrolledCourses = 6;
            
            // Static variables
            Student.MaxBooksAllowed = 8;
            Console.WriteLine(Student.MaxBooksAllowed);

            // Value and reference types
            Console.WriteLine("Value and reference types");
            int a = 10;
            Console.WriteLine(a);
            int b = a;
            b = 20;
            Console.WriteLine(a);

            student.FirstName = "John";
            Console.WriteLine(student.FirstName);
            student2 = student;
            student2.FirstName = "Ashok";
            Console.WriteLine(student.FirstName);

            // Access modifiers
            staff.FirstName = "Staff1";
        }
    }
}
