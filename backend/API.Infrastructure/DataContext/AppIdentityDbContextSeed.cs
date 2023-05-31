using API.Core.DbModels.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.DataContext
{
    public class AppIdentityDbContextSeed
    {
        public static  void SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Onur",
                    Email = "onur.ertekin@outlook.com",
                    UserName = "onur.ertekin@outlook.com",
                    Address = new Address
                    {
                        FirstName = "Onur",
                        LastName = "Ertekin",
                        Street = "Atatürk Cad",
                        City = "Canakkale",
                        State = "TR",
                        ZipCode = "34000"
                    }
                };
                userManager.CreateAsync(user, "A123456");
            }
        }
    }
}
