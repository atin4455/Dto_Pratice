using Dto_Pratice.Models;

namespace Dto_Pratice.Services;

public class UserDemoService : IUserDemoService
{
    public UserDemoViewModel GetDtoDemoPage()
    {
        var dto = new UserDto
        {
            Id = 1,
            Name = "示範使用者",
            Email = "demo@example.com"
        };

        return new UserDemoViewModel
        {
            User = dto,
            Greeting = $"嗨，{dto.Name}（這行只為畫面組字，不屬於 DTO）"
        };
    }
}
