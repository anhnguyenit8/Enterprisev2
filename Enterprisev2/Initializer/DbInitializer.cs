using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Enterprisev2.Static;
using Enterprisev2.Models;

namespace WebEcommerce.Initializer
{
    public class DbInitializer: IDbInitializer
    {        
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder builder)
        {
            using (var applicationservices = builder.ApplicationServices.CreateScope())
            {
                #region Role

                var roleManager =
                    applicationservices.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                
                if(! await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }

                #endregion

                #region User

                var userManager =
                    applicationservices.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                
                if(await userManager.FindByEmailAsync("admin@gmail.com") == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        Email = "admin@gmail.com",
                        EmailConfirmed = true,
                        FullName = "Admin User",
                        UserName = "Admin"
                    };
                    await userManager.CreateAsync(newAdminUser,"@Admin123");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);

                    if (await userManager.FindByEmailAsync("user@gmail.com") == null)
                    {
                        var newOriginalUser = new ApplicationUser()
                        {
                            Email = "user@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Original User",
                            UserName = "User"
                        };
                        await userManager.CreateAsync(newOriginalUser, "@User123");
                        await userManager.AddToRoleAsync(newOriginalUser, UserRoles.User);
                    }
                }

                #endregion

            }
        }
    }
}
