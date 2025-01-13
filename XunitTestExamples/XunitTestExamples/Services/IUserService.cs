using XunitTestExamples.Models;

namespace XunitTestExamples.Services;

public interface IUserService
{
    DateTime Now { get; }
    User GetUserById(int id);
    List<User> GetAllUsers();
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
}