using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class UserService : IUserService
    {
        public List<UserBase> Users = new();

        public UserService()
        {
            Users = GetAllUsers();
        }

        // Lägger till en användare
        public void AddUser(UserBase user)
        {
            Users.Add(user);
        }

        // Hämtar användare baserat på ID
        // Returnerar användaren med matchande ID eller kastar ett undantag om användaren inte finns.
        public UserBase GetUserById(int id)
        {
            try
            {
                return Users[id];
            }
            catch (Exception ex) {
                Console.WriteLine($"Error while getting user: {ex.Message}");
                // Returns an empty regular user if something goes wrong.
                return null! ;
            }
        }

        // Hämta alla användare
        // Returnerar alla användare.
        public List<UserBase> GetAllUsers()
        {
            return Users ;
        }


        public int GetUserCount()
        {
            if (Users == null) { 
                return 0 ;
            }
            return Users.Count;
        }
        public void KillAllUsers()
        {
            Users.Clear();
        }
    }
}
