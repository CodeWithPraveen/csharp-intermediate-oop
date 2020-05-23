using System.Collections.Generic;

namespace CMS.UI.Models
{

    public class Course : ICourse
    {
        public int CourseId;
        public string CourseName;
        public static int MaxSubjects = 8;
        public int TotalDurationInDays { get; set; }

        private List<CourseSubject> subjects = null;

        public List<CourseSubject> Subjects
        {
            get { return subjects; }
            private set { subjects = value; }
        }

        public void AddSubject(CourseSubject subject)
        {
            subjects.Add(subject);
        }

        public void RemoveSubject(CourseSubject subject)
        {
            subjects.Remove(subject);
        }

        public void AddSubject(List<CourseSubject> subjectsList)
        {
            subjects.AddRange(subjectsList);
        }
    }
}