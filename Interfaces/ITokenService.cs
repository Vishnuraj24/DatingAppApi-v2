using MyDatingAppAPI.Models;

namespace MyDatingAppAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
