namespace CMS.UI.Models
{
    public interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        static int MaxBooksAllowed = 6;

        string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        static string WhoAmI()
        {
            return "Student";
        }
    }
}