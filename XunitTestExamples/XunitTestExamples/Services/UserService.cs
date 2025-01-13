using XunitTestExamples.Models;

namespace XunitTestExamples.Services;

public class UserService : IUserService
{
    private readonly List<User> _users;
    public DateTime Now { get; }

    public UserService(List<User> users, DateTime now)
    {
        Now = now;
        _users = users;
        // new List<User>
        // {
        //     new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
        //     new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        // };
    }

    public User GetUserById(int id)
    {
        if(Now > DateTime.Today)
        {
            return new User();
        }
        return _users.FirstOrDefault(user => user.Id == id);
    }

    public List<User> GetAllUsers()
    {
        return _users;
    }

    public void AddUser(User user)
    {
        if (user != null && !_users.Any(u => u.Id == user.Id))
        {
            _users.Add(user);
        }
    }

    public void UpdateUser(User user)
    {
        var existingUser = GetUserById(user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
        }
    }

    public void DeleteUser(int id)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            _users.Remove(user);
        }
    }
}