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
                    applicationservices.ServiceProvider.GetRequiredService<UserManager<User>>();
                
                if(await userManager.FindByEmailAsync("admin@admin.com") == null)
                {
                    var newAdminUser = new User() {
                        Email = "admin@admin.com", EmailConfirmed = true, UserName = "Admin" };
                    await userManager.CreateAsync(newAdminUser,"@Admin123");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);

                    if (await userManager.FindByEmailAsync("user@user.com") == null)
                    {
                        var newOriginalUser = new User()
                        {
                            Email = "user@user.com",
                            EmailConfirmed = true,
                            /*FullName = "Original User",*/
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
