using ChatModels;
using ChatModels.Models;
using DemoBlazorWebAppWasmSignalRChat.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DemoBlazorWebAppWasmSignalRChat.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<GroupChat> GroupChats { get; set; }
        public DbSet<AvailableUser> AvailableUsers { get; set; }
        public DbSet<IndividualChat> IndividualChats { get; set; }
    }
}
