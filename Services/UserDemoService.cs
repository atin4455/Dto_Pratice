using Dto_Pratice.Data;
using Dto_Pratice.Models;

namespace Dto_Pratice.Services;

public class UserDemoService(AppDbContext dbContext) : IUserDemoService
{
    public UserDemoViewModel GetDtoDemoPage()
    {
        var userEntity = dbContext.Users.FirstOrDefault();

        var dto = userEntity is null
            ? new UserDto
            {
                Id = 1,
                Name = "示範使用者",
                Email = "demo@example.com"
            }
            : new UserDto
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Email = userEntity.Email
            };

        return new UserDemoViewModel
        {
            User = dto,
            Greeting = $"嗨，{dto.Name}（這行只為畫面組字，不屬於 DTO）"
        };
    }
}
