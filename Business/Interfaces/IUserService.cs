using Business.Models;

namespace Business.Interfaces
{
    public interface IUserService
    {
        public void AddUser(UserBase user);
        public List<UserBase> GetAllUsers();
        public UserBase GetUserById(int id);
        public int GetUserCount();
    }
}