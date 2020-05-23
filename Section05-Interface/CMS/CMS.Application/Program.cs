using System;
using CMS.UI.Display;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourse csCourse = new CSCourse();
            ICourse eleCourse = new ElectronicsCourse();

            Console.WriteLine(csCourse.GetTotalElectives());
        }
    }
}
