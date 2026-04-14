namespace Dto_Pratice.Models
{
    // 純資料形狀（例如服務／API 邊界），通常不夾「這一頁才要的字」
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
