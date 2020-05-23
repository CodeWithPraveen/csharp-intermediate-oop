namespace CMS.UI.Models
{
    public class Staff : Person
    {
        public int Id { get; private set; }

        public int WorkingHoursPerWeek { get; set; }

        public Staff()
        {
            FirstName = "Staff1";
        }

        public Staff(string firstName, string lastName)
            : base(firstName, lastName)
            {
                // Staff class initializations go here. 
                WorkingHoursPerWeek = 40;
            }

        protected void CalculateFees(decimal electiveFees, ref decimal roughFees,
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

        private protected void UpdateInfo(string firstName, string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}