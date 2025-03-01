using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Identity;

namespace Talabat.Repository.Identity
{
    public static class AppIdnetityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<AppUser> _userManager)
        {
            var user = new AppUser
            {
                DisplayName = "Bob",
                Email = "bob@linkdev.com",
                UserName = "bob",
                PhoneNumber = "1234567890",
            };

            await _userManager.CreateAsync(user, "Pa$$w0rd");
        }
    }
}
 