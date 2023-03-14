using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web1_1.DAL.Data;
using web1_1.DAL.Entities;

namespace web1_1.Services
{
    public class DbInitializer
    {
        public static async Task SeedProducts(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>()!;
                // создать БД, если она еще не создана
                context.Database.EnsureCreated();
                //проверка наличия групп объектов
                if (!context.WheelchairGroups.Any())
                {
                    context.WheelchairGroups.AddRange(
                    new List<WheelchairGroup>
                    {
                            new WheelchairGroup {GroupName="Активные инвалидные коляски"},
                            new WheelchairGroup {GroupName="Инвалидные коляски с электроприводом"},
                            new WheelchairGroup {GroupName="Кресло-коляски для инвалидов с ДЦП"},
                            new WheelchairGroup {GroupName="Кресло-коляски для инвалидов с ручным приводом"},
                            new WheelchairGroup {GroupName="Складные инвалидные кресла рычажного типа"}
                    });
                    //await context.SaveChangesAsync();

                }
                // проверка наличия объектов
                if (!context.Wheelchairs.Any())
                {
                    context.Wheelchairs.AddRange(
                    new List<Wheelchair>
                    {
                            new Wheelchair {WheelchairName="Кушаль1",
                            Description="Вес 10 кг, Спинка 35 см, Сиденье 30 см, Баланс, Обода - резина, Корпус - Карбон",
                            Price = 2400, WheelchairGroupId = 1, Image="kus1.jpg" },
                            new Wheelchair {WheelchairName="Кушаль2", 
                                Description="Вес 13 кг, Спинка 45 см, Сиденье 40 см, Обода - резина, Корпус - Алюминий",
                            Price = 1200,WheelchairGroupId = 1, Image = "kus2.jpg"},
                            new Wheelchair {WheelchairName="Кушаль3",
                                Description="Вес 12 кг, Спинка 40 см, Сиденье 35 см, Обода - резина, Корпус - Алюминий",
                            Price = 2200,WheelchairGroupId = 1, Image = "kus3.jpg"},
                            new Wheelchair {WheelchairName="Кушаль4",
                                Description="Вес 11 кг, Спинка 34 см, Сиденье 28 см, Обода - резина, Корпус - Алюминий",
                            Price = 1700,WheelchairGroupId = 1, Image = "kus4.jpg"},
                            new Wheelchair {WheelchairName="Кушаль5",
                                Description="Вес 8 кг, Спинка 30 см, Сиденье 32 см, Баланс, Обода - резина, Корпус - Карбон",
                            Price = 1500,WheelchairGroupId = 1, Image = "kus5.jpg"},
                            new Wheelchair {WheelchairName="Кушаль6",
                                Description="Вес 10 кг, Спинка 35 см, Сиденье 37 см, Обода - алюминий, Корпус - Карбон",
                            Price = 3500,WheelchairGroupId = 1, Image = "kus6.jpg"},
                           
                            new Wheelchair {WheelchairName="Ортоника1",
                                Description="Вес 20 кг, Спинка 50 см, Сиденье 50 см, Обода - резина, Корпус - Алюминий",
                            Price = 450,WheelchairGroupId = 1, Image = "orton1.jpg"},
                            new Wheelchair {WheelchairName="Ортоника2",
                            Description="Вес 15 кг, Спинка 40 см, Сиденье 40 см, Обода - резина, Корпус - Алюминий",
                            Price =650, WheelchairGroupId=1, Image="orton2.jpg" },
                            new Wheelchair {WheelchairName="Ортоника3",
                            Description="Вес 16 кг, Спинка 30 см, Сиденье 45 см, Обода - резина, Корпус - Алюминий",
                            Price =350, WheelchairGroupId=1, Image="orton3.jpg" },
                            new Wheelchair {WheelchairName="Ортоника4",
                            Description="Вес 17 кг, Спинка 40 см, Сиденье 45 см, Обода - резина, Корпус - Алюминий",
                            Price =550, WheelchairGroupId=1, Image="orton4.jpg" },
                            new Wheelchair {WheelchairName="Ортоника5",
                            Description="Вес 14 кг, Спинка 35 см, Сиденье 35 см, Обода - резина, Корпус - Алюминий",
                            Price =700, WheelchairGroupId=1, Image="orton5.jpg" },

                            new Wheelchair {WheelchairName="Отобок1",
                                Description="Вес 16 кг, Спинка 35 см, Сиденье 40 см, Обода - резина, Корпус - Алюминий",
                            Price = 1200,WheelchairGroupId = 1, Image = "ottob1.jpg"},
                            new Wheelchair {WheelchairName="Отобок2",
                                Description="Вес 12 кг, Спинка 55 см, Сиденье 35 см, Обода - резина, Корпус - Алюминий",
                            Price = 900,WheelchairGroupId = 1, Image = "ottob2.jpg"},
                            new Wheelchair {WheelchairName="Отобок3",
                                Description="Вес 14 кг, Спинка 45 см, Сиденье 40 см, Обода - резина, Корпус - Алюминий",
                            Price = 1400,WheelchairGroupId = 1, Image = "ottob3.jpg"},
                            new Wheelchair {WheelchairName="Отобок4",
                                Description="Вес 7 кг, Спинка 40 см, Сиденье 45 см, Баланс, Обода - резина, Корпус - Корбон",
                            Price = 3800,WheelchairGroupId = 1, Image = "ottob4.jpg"},
                            new Wheelchair {WheelchairName="Отобок5",
                                Description="Вес 13 кг, Спинка 35 см, Сиденье 30 см, Обода - резина, Корпус - Алюминий",
                            Price = 800,WheelchairGroupId = 1, Image = "ottob5.jpg"},

                             new Wheelchair {WheelchairName="Пантера1",
                                Description="Вес 10 кг, Спинка 35 см, Сиденье 35 см, Обода - алюминий, Корпус - Алюминий",
                            Price = 1800,WheelchairGroupId = 1, Image = "pant1.jpg"},
                             new Wheelchair {WheelchairName="Пантера2",
                                Description="Вес 10 кг, Спинка 35 см, Сиденье 35 см, Обода - алюминий, Корпус - Алюминий",
                            Price = 3400,WheelchairGroupId = 1, Image = "pant2.jpg"},
                             new Wheelchair {WheelchairName="Пантера3",
                                Description="Вес 10 кг, Спинка 35 см, Сиденье 35 см, Обода - алюминий, Корпус - Алюминий",
                            Price = 2000,WheelchairGroupId = 1, Image = "pant3.jpg"},
                             new Wheelchair {WheelchairName="Пантера4",
                                Description="Вес 10 кг, Спинка 35 см, Сиденье 35 см, Обода - резина, Корпус - Алюминий",
                            Price = 4500,WheelchairGroupId = 1, Image = "pant4.jpg"},
                             new Wheelchair {WheelchairName="Пантера5",
                                Description="Вес 10 кг, Спинка 35 см, Сиденье 35 см, Обода - резина, Корпус - Алюминий",
                            Price = 1500,WheelchairGroupId = 1, Image = "pant5.jpg"},

                            new Wheelchair {WheelchairName="Электро-инва1",
                            Description="Вес 160 кг, Спинка 90 см, Сиденье 50 см, Скорость 20 км/ч, Запас хода 50 км ",
                            Price =5000, WheelchairGroupId=2, Image="elec1.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва2",
                            Description="Вес 70 кг, Спинка 80 см, Сиденье 50 см, Скорость 8 км/ч, Запас хода 15 км ",
                            Price =650, WheelchairGroupId=2, Image="elec3.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва3",
                            Description="Вес 90 кг, Спинка 85 см, Сиденье 45 см, Скорость 15 км/ч, Запас хода 30 км ",
                            Price =1400, WheelchairGroupId=2, Image="elec2.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва4",
                            Description="Вес 120 кг, Спинка 70 см, Сиденье 55 см, Скорость 10 км/ч, Запас хода 30 км ",
                            Price =3500, WheelchairGroupId=2, Image="elec4.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва5",
                            Description="Вес 95 кг, Спинка 65 см, Сиденье 40 см, Скорость 15 км/ч, Запас хода 35 км ",
                            Price =1000, WheelchairGroupId=2, Image="elec5.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва6",
                            Description="Вес 50 кг, Спинка 50 см, Сиденье 50 см, Скорость 6 км/ч, Запас хода 10 км ",
                            Price =500, WheelchairGroupId=2, Image="elec6.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва7",
                            Description="Вес 130 кг, Спинка 50 см, Сиденье 50 см, Скорость 15 км/ч, Запас хода 40 км ",
                            Price =1200, WheelchairGroupId=2, Image="elec7.jpg" },
                            new Wheelchair {WheelchairName="Электро-инва8",
                            Description="Вес 120 кг, Спинка 50 см, Сиденье 50 см, Скорость 15 км/ч, Запас хода 40 км ",
                            Price =900, WheelchairGroupId=2, Image="elec8.jpg" },

                            new Wheelchair {WheelchairName="Коляска для ДЦП-1",
                            Description="Вес 25 кг, Спинка 90 см, Сиденье 50 см, Столик, Домашняя, Ручной турмоз",
                            Price =400, WheelchairGroupId=3, Image="dzp1.jpg" },
                             new Wheelchair {WheelchairName="Коляска для ДЦП-2",
                            Description="Вес 15 кг, Спинка 65 см, Сиденье 50 см, Столик, Подголовник, Домашняя",
                            Price =400, WheelchairGroupId=3, Image="dzp2.jpg" },
                              new Wheelchair {WheelchairName="Коляска для ДЦП-3",
                            Description="Вес 17 кг, Спинка 70 см, Сиденье 50 см, Регулировщик сиденья, Подголовник, Прогулочная",
                            Price =300, WheelchairGroupId=3, Image="dzp3.jpg" },
                               new Wheelchair {WheelchairName="Коляска для ДЦП-4",
                            Description="Вес 20 кг, Спинка 90 см, Сиденье 50 см, Козырёк, Корзинка, Прогулочная",
                            Price =450, WheelchairGroupId=3, Image="dzp4.jpg" },
                                new Wheelchair {WheelchairName="Коляска для ДЦП-5",
                            Description="Вес 14 кг, Спинка 65 см, Сиденье 50 см, Корзинка, Складная, Прогулочная",
                            Price =500, WheelchairGroupId=3, Image="dzp5.jpg" },

                            new Wheelchair {WheelchairName="Ручная 1",
                            Description="Вес 20 кг, Спинка 40 см, Сиденье 40 см, Бескамерные шины, Разборная, метал - Железо",
                            Price=150, WheelchairGroupId=4, Image="rush1.jpg" },
                             new Wheelchair {WheelchairName="Ручная 2",
                            Description="Вес 20 кг, Спинка 35 см, Сиденье 45 см, Бескамерные шины, Разборная, метал - Железо",
                            Price=120, WheelchairGroupId=4, Image="rush2.jpg" },
                              new Wheelchair {WheelchairName="Ручная 3",
                            Description="Вес 30 кг, Спинка 35 см, Сиденье 35 см, С камерой, Разборная, метал - Алюминий",
                            Price=600, WheelchairGroupId=4, Image="rush3.jpg" },

                            new Wheelchair {WheelchairName="Складная 1",
                            Description="Вес 18 кг, Спинка 45 см, Сиденье 40 см, метал - Железо, Рычажная",
                            Price =280, WheelchairGroupId=5, Image="sck1.jpg" },
                            new Wheelchair {WheelchairName="Складная 2",
                            Description="Вес 15 кг, Спинка 40 см, Сиденье 50 см, метал - Алюминий, Ручная",
                            Price =280, WheelchairGroupId=5, Image="sck2.jpg" }
                    });

                }
                await context.SaveChangesAsync();
            }
        }


        public static async Task SeedIdentity(IApplicationBuilder applicationBuilder)
        {

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppIdentityDbContext>()!;
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>()!;
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<ApplicationUser>>()!;
                context.Database.EnsureCreated();

                if (!context.Roles.Any())
                {
                    string[] roles = new string[] { "admin" };

                    foreach (string role in roles)
                    {
                        if (!context.Roles.Any(r => r.Name == role))
                        {
                            await roleManager.CreateAsync(new IdentityRole(role));
                        }
                    }
                }
                if (!context.Users.Any())
                {
                    // создать пользователя admin
                    var admin = new ApplicationUser
                    {
                        Email = "admin@test.com",
                        UserName = "admin@test.com",
                        NormalizedEmail = "ADMIN@TEST.COM",
                        NormalizedUserName = "ADMIN@TEST.COM",
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        SecurityStamp = Guid.NewGuid().ToString("D"),
                        PhoneNumber = "+375294685978"
                    };

                    if (!context.Users.Any(u => u.UserName == admin.UserName))
                    {
                        var password = new PasswordHasher<ApplicationUser>();
                        var hashed = password.HashPassword(admin, "123456");
                        admin.PasswordHash = hashed;
                        var result = userManager.CreateAsync(admin);
                    }

                    await userManager.AddToRoleAsync(admin, "admin");


                    ////Создать пользователя с правами админа
                    //var admin = new ApplicationUser
                    //{
                    //    Email = "admin@test.com",
                    //    UserName = "admin@test.com",
                    //    NormalizedEmail = "ADMIN@TEST.COM",
                    //    NormalizedUserName = "ADMIN@TEST.COM",
                    //    EmailConfirmed = true,
                    //    PhoneNumberConfirmed = true,
                    //    SecurityStamp = Guid.NewGuid().ToString("D"),
                    //    PhoneNumber = "+375294652348"
                    //};

                    //if (!context.Users.Any(u => u.UserName == admin.UserName))
                    //{
                    //    var password = new PasswordHasher<ApplicationUser>();
                    //    var hashed = password.HashPassword(admin, "1234");
                    //    admin.PasswordHash = hashed;

                    //    var result = userManager.CreateAsync(admin);
                    //}

                    //await userManager.AddToRoleAsync(admin, "admin");
                    await context.SaveChangesAsync();

                }
            }
        }
    }
}

