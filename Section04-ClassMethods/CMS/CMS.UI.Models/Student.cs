using System;

namespace CMS.UI.Models
{
    public class Student
    {
        // Class fields
        public string FirstName = default;
        public string LastName = string.Empty;
        public int StudentId = 10000;

        // const field
        //public const int MaxEnrolledCourses = 3;

        // readonly field
        public readonly int MaxEnrolledCourses = 3;

        // Static field
        public static int MaxBooksAllowed = 6;

        // Student constructor
        public Student()
        {
            Console.WriteLine("Calling Student.Student()");

            // All initializations goes here. 
            int TotalCourses = 6;
            MaxEnrolledCourses = TotalCourses;
        }

        public Student(int id, string firstName, string lastName)
        {
            Console.WriteLine("Calling Student.Student(int, string, string)");

            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        ~Student()
        {
            // Cleanup code goes here. 

        }

        public int GetId()
        {
            return StudentId;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
