using System;
using System.Collections.Generic;

namespace CMS.UI.Models
{
    public class Course : ICourse
    {
        public int CourseId;
        public string CourseName;
        public static int MaxSubjects = 8;
        public int TotalDurationInDays { get; set; }

        private List<CourseSubject> subjects = new List<CourseSubject>();

        public List<CourseSubject> Subjects
        {
            get { return subjects; }
            private set { subjects = value; }
        }

        public virtual void AddSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling Course.AddSubject(CourseSubject)");

            subjects.Add(subject);
        }

        public virtual void RemoveSubject(CourseSubject subject)
        {
            subjects.Remove(subject);
        }

        public void AddSubject(List<CourseSubject> subjectsList)
        {
            subjects.AddRange(subjectsList);
        }
    }
}