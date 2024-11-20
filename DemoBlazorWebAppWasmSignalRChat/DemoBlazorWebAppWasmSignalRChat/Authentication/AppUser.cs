using Microsoft.AspNetCore.Identity;
namespace DemoBlazorWebAppWasmSignalRChat.Authentication
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; } = string.Empty;
    }
}
