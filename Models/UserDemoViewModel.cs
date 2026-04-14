namespace Dto_Pratice.Models
{
    // 專給這個畫面：可包進 DTO，或加只跟 UI 有關的欄位
    public class UserDemoViewModel
    {
        public UserDto User { get; set; } = new();
        public string Greeting { get; set; } = string.Empty;
    }
}
