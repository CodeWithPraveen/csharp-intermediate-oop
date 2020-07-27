# Problem Statements
For the Staff class, do the following: 
1. Make it derive from the Person class and remove the properties from the Staff class that is already defined in the Person class. 

2. Add WorkingHoursPerWeek as an additional property to the Staff class.

3. Add Staff(string firstName, string LastName) constructor and pass the values to the corresponding Person class constructor. Also, assign 40 hours to the WorkingHoursPerWeek property in this constructor.

4. Add appropriate access modifier to the CalculateFees method so that it is accessible by any derived type of Staff class. Similarly, make the UpdateInfo method to be accessible by any derived type of Staff class, but within CMS.UI.Display assembly only. 

5. In the console application, CMS.Application, create an instance of Staff class initializing with “Mary Smith” name and assign it to Person instance person2. Next, print its WorkingHoursPerWeek value to the console only if person2 is of type Staff.
