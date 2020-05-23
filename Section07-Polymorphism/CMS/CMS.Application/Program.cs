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
        }
    }
}
