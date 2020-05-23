namespace CMS.UI.Models
{
    public abstract class Hobby
    {
        private string name; 
        public string GetHobbyName()
        {
            return name;
        }

        public abstract string GetTypeOfHobby();  

        public void Initiaze(string hobbyName)
        {
            name = hobbyName;
        }      
    }

    public class PhotographyHobby : Hobby
    {
        public override string GetTypeOfHobby()
        {
            throw new System.NotImplementedException();
        }
    }
}