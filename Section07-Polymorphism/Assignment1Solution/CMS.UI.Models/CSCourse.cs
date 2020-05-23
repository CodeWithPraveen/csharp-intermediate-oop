using System.Collections.Generic;
using System;

namespace CMS.UI.Models
{
    public class CSCourse : Course
    {
        public sealed override void AddSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling CSCourse.AddSubject(CourseSubject)");

            // Custom business logic go here.
        }
    }
}