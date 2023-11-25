using API.Entities;

namespace API.Interfaces
{
  public interface IUserRepository
  {
    void Update(AppUser user);
    Task<bool> SavellAsync();
    Task<IEnumerable<AppUser>> GetUserAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByUsernameAsync(string username);
  }
}

