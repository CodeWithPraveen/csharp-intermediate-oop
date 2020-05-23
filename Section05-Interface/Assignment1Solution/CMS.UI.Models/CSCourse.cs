using System.Collections.Generic;

namespace CMS.UI.Models
{
    public class CSCourse : ICourse
    {
        public int TotalDurationInDays { get; set; }
        public List<CourseSubject> Subjects => throw new System.NotImplementedException();

        public void AddSubject(CourseSubject subject)
        {
            throw new System.NotImplementedException();
        }

        public void AddSubject(List<CourseSubject> subjectsList)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveSubject(CourseSubject subject)
        {
            throw new System.NotImplementedException();
        }
    }
}