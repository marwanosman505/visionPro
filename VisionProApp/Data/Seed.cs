using Microsoft.AspNetCore.Identity;
using VisionProApp.Models;
using System.Diagnostics;
using System.Net;
using VisionProApp.Data;

namespace VisionProApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                //context.Database.EnsureCreated();

                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(new List<Client>()
                    {
                        new Client()
                        {
                            Name = "Marwan"
                         },
                        new Client()
                        {
                            Name = "Osman"
                        },
                        new Client()
                        {
                           Name = "Alex"
                        }
                    });
                    context.SaveChanges();
                }

                // Sites
                if (!context.Sites.Any())
                {
                    var clients = context.Clients.ToList();

                    var sitesToAdd = new List<Site>()
                    {
                        new Site() { Name = "School", ClientId = clients[0].Id },
                        new Site() { Name = "Office", ClientId = clients[0].Id },
                        new Site() { Name = "Hospital", ClientId = clients[1].Id },
                        // Adding 5 more sites
                        new Site() { Name = "Library", ClientId = clients[0].Id },
                        new Site() { Name = "Museum", ClientId = clients[1].Id },
                        new Site() { Name = "Factory", ClientId = clients[1].Id },
                        new Site() { Name = "Gym", ClientId = clients[0].Id },
                        new Site() { Name = "Cafe", ClientId = clients[1].Id }
                    };

                    context.Sites.AddRange(sitesToAdd);
                    context.SaveChanges();
                }

                // Buildings
                if (!context.Buildings.Any())
                {
                    var sites = context.Sites.ToList();

                    var buildingsToAdd = new List<Building>()
                    {
                        new Building { Name = "Building A", SiteId = sites[0].Id },
                        new Building { Name = "Building B", SiteId = sites[1].Id },
                        new Building { Name = "Building C", SiteId = sites[2].Id },
                        // Adding 5 more buildings
                        new Building { Name = "Building D", SiteId = sites[3].Id },
                        new Building { Name = "Building E", SiteId = sites[4].Id },
                        new Building { Name = "Building F", SiteId = sites[5].Id },
                        new Building { Name = "Building G", SiteId = sites[6].Id },
                        new Building { Name = "Building H", SiteId = sites[7].Id }
                    };

                    context.Buildings.AddRange(buildingsToAdd);
                    context.SaveChanges();
                }

                // Rooms
                if (!context.Rooms.Any())
                {
                    var buildings = context.Buildings.ToList();

                    var roomsToAdd = new List<Room>()
                    {
                        new Room { Name = "Room 1", BuildingId = buildings[0].Id },
                        new Room { Name = "Room 2", BuildingId = buildings[1].Id },
                        new Room { Name = "Room 3", BuildingId = buildings[2].Id },
                        // Adding 5 more rooms
                        new Room { Name = "Room 4", BuildingId = buildings[3].Id },
                        new Room { Name = "Room 5", BuildingId = buildings[4].Id },
                        new Room { Name = "Room 6", BuildingId = buildings[5].Id },
                        new Room { Name = "Room 7", BuildingId = buildings[6].Id },
                        new Room { Name = "Room 8", BuildingId = buildings[7].Id }
                    };

                    context.Rooms.AddRange(roomsToAdd);
                    context.SaveChanges();
                }

                // Assets
                if (!context.Assets.Any())
                {
                    // Assuming each new asset is related to a client for simplicity
                    var rooms = context.Rooms.ToList();

                    var assetsToAdd = new List<Asset>()
                    {
                        new Asset { Name = "Asset 1", RoomId = rooms[0].Id },
                        new Asset { Name = "Asset 2", RoomId = rooms[0].Id },
                        // Adding 5 more assets
                        new Asset { Name = "Asset 3", RoomId = rooms[1].Id },
                        new Asset { Name = "Asset 4", RoomId = rooms[1].Id },
                        new Asset { Name = "Asset 5", RoomId = rooms[2].Id },
                        new Asset { Name = "Asset 6", RoomId = rooms[3].Id },
                        new Asset { Name = "Asset 7", RoomId = rooms[4].Id },
                        new Asset { Name = "Asset 8", RoomId = rooms[0].Id },
                        // Adding 5 more assets
                        new Asset { Name = "Asset 9", RoomId = rooms[1].Id },
                        new Asset { Name = "Asset 10", RoomId = rooms[5].Id },
                        new Asset { Name = "Asset 11", RoomId = rooms[6].Id },
                        new Asset { Name = "Asset 12", RoomId = rooms[7].Id },
                        new Asset { Name = "Asset 13", RoomId = rooms[4].Id }
                    };

                    context.Assets.AddRange(assetsToAdd);
                    context.SaveChanges();
                }

            }
        }
        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}

    }
}