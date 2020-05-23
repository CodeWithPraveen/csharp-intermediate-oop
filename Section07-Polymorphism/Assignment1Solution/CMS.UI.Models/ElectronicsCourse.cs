using System.Collections.Generic;
using System;

namespace CMS.UI.Models
{
    public class ElectronicsCourse : Course
    {
        public new void AddSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling ElectronicsCourse.AddSubject(CourseSubject)");

            // Custom business logic go here. 

            return;
        }

        public override void RemoveSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling ElectronicsCourse.RemoveSubject(CourseSubject)");

            // Custom business logic go here. 

            return;
        }
    }
}