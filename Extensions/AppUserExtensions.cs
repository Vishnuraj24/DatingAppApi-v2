using MyDatingAppAPI.Dtos;
using MyDatingAppAPI.Interfaces;
using MyDatingAppAPI.Models;
using MyDatingAppAPI.Services;

namespace MyDatingAppAPI.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDto ToDto(this AppUser user, ITokenService _tokenService)
        {
            var userDto = new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                DisplayName = user.DisplayName,
                Token = _tokenService.CreateToken(user)
            };

            return userDto;
        }
    }
}
