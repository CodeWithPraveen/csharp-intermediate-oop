using System.Collections.Generic;

namespace CMS.UI.Models
{
    public interface ICourse
    {
        static int DefaultElectives = 8;
        
        static void ShowDetails()
        {
            // details go here.
        }
       
        int TotalDurationInDays { get; set; }
        int TotalSubjects 
        {
            get
            {
                return Subjects.Count;
            }
        }  
        List<CourseSubject> Subjects { get; }

        void AddSubject(CourseSubject subject);
        void AddSubject(List<CourseSubject> subjectsList);
        void RemoveSubject(CourseSubject subject);
        int GetTotalElectives()
        {
            return 0;
        }
    }
}