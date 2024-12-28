namespace BlogApp.BL.Services.Interfaces;
public interface IUserService
{
    Task<string> CreateAsync();
    Task DeleteAsync(string username);

}
