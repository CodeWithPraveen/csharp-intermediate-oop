using System;
using CMS.UI.Display;
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

            // Methods
            Student student3 = new Student()
            {
                FirstName = "John",
                LastName = "McCarter",
                StudentId = 10003
            };
            Console.WriteLine(student3.GetId());
            Console.WriteLine(student3.GetFullName());
            
            // Constructor and Destructor
            Student student4 = new Student();
            Student student5 = new Student(10004, "Ashok", "Kumar");

            // Properties
            Staff staff3 = new Staff();
            string name = staff3.FirstName;     
            name = staff3.LastName;
            int iD = staff3.Id;
            //staff3.Id = 10005;

            // Types of passing parameters
            decimal electiveFees = 5000;
            decimal roughFees = 5000;
            decimal finalFees = 5000;
            Console.WriteLine(electiveFees);
            Console.WriteLine(roughFees);
            Console.WriteLine(finalFees);

            staff3.CalculateFees(electiveFees, ref roughFees, out finalFees);
            
            Console.WriteLine("After calculating fees");
            Console.WriteLine(electiveFees);
            Console.WriteLine(roughFees);
            Console.WriteLine(finalFees);

            // Method overloading
            staff3.UpdateInfo("John");
            staff3.UpdateInfo("John", "McCarter");

            // Static class
            Display.Show("Hello");

        }
    }
}
