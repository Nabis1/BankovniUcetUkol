

namespace BankovniUcetUkol
{
    public class User
    {
        public string FirstName{ get; private set; }
        public string LastName { get; private set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetInfo()
        {
            return $"Client identification\n Name and Surname : {FirstName}  {LastName}.";
        }
    }
}
