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
            Course course = new CSCourse();
            course.AddSubject(new CourseSubject(301, "Programming"));

            Course electronicsCourse = new ElectronicsCourse();
            CourseSubject subject = new CourseSubject(401, "Basics of Electrical Science");
            electronicsCourse.AddSubject(subject);
            electronicsCourse.RemoveSubject(subject);

            // Expected output.
            // Calling CSCourse.AddSubject(CourseSubject)
            // Calling Course.AddSubject(CourseSubject)
            // Calling ElectronicsCourse.RemoveSubject(CourseSubject)
        }
    }
}
