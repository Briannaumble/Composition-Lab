namespace Composition_Lab
{
    public class Author
    {
        private string Name {get; set;}
        private char Gender {get; set;}
        private string Email {get; set;}

        public Author(string tempName, char tempGender, string tempEmail)
        {
            this.Name = tempName;
            this.Gender = tempGender;
            this.Email = tempEmail;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string tempName)
        {
            this.Name = tempName;
        }
        public char GetGender()
        {
            return Gender;
        }
        public void SetGender(char tempGender)
        {
            this.Gender = tempGender;
        }
        public string GetEmai()
        {
            return Email;
        }
        public void SetEmail(string tempEmail)
        {
            this.Email = tempEmail;
        }
        public override string ToString()
        {
            return "name = " +Name+ ", email = " +Email+ ", gender = " +Gender;
        }
    }
}