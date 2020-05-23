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
            // All initializations goes here. 
            int TotalCourses = 6;
            MaxEnrolledCourses = TotalCourses;
        }
    }
}
