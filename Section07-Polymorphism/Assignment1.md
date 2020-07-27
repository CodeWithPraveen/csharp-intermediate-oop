# Problem Statements
For the ElectronicsCourse class, do the following: 
1. Make it derive from the Course class and remove the members from it that are already defined in the Course class. 

2. Add the AddSubject method that hides the corresponding implementation from the Course class.

3. Add virtual to the RemoveSubject method in Course class and override the same in the ElectronicsCourse class.

4. Create electronicsCourse instance for ElectronicsCourse class in the console application. Call AddSubject with a new course subject instance with id as 401 and subjectName as “Basics of Electrical Science”. Then call RemoveSubject method to remove the previously added course subject. Run the program and check whether the appropriate method from a base class or derived class gets triggered.
