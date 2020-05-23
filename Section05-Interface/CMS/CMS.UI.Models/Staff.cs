namespace CMS.UI.Models
{
    public class Staff
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName { get; set; } = string.Empty;

        public int Id { get; private set; }

        public Staff()
        {
            FirstName = "Staff1";
        }

        public void CalculateFees(decimal electiveFees, ref decimal roughFees,
            out decimal finalFees)
            {
                electiveFees = 10000;
                roughFees = 10000;
                finalFees = 10000;
            }
        
        // public void UpdateInfo(string firstName)
        // {
        //     FirstName = firstName;
        // }

        public void UpdateInfo(string firstName, string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}