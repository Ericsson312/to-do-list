using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class IdentityDataSeeder
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Secret123$";

        public static void EnsureAdminCreated(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByIdAsync(adminUser).Result == null)
            {
                IdentityUser user = new IdentityUser(adminUser);

                IdentityResult result = userManager.CreateAsync(user, adminPassword).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
