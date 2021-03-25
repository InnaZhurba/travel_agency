namespace DAL_Users.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using DAL_Users.UserEntities;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL_Users.EF.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL_Users.EF.DBContext context)
        {
            var administrators = new List<Administrator>
            {
                new Administrator{Login = "InZhu", Password = "Zhuzhu",},
                new Administrator{Login = "IwWud", Password = "123456",},
                new Administrator{Login = "OlBon", Password = "111111",}
            };
            administrators.ForEach(s => context.Administrators.AddOrUpdate(s));
            context.SaveChanges();

            var managers = new List<Manager>
            {
                new Manager{Name = "Inna", Login = "Inna.zhurba", Password = "Zhurba",},
                new Manager{Name = "Iwan", Login = "iwan.wudrin", Password = "Wudrin",},
                new Manager{Name = "Oleksandr", Login = "oleksandr.bondar", Password = "Bondar",}
            };
            managers.ForEach(s => context.Managers.AddOrUpdate(s));
            context.SaveChanges();

            var info = new List<UserInfo>
            {
                new UserInfo{Name ="Kate", Email = "kate@gmail.com",},
                new UserInfo{Name ="Lew", Email = "lewInfo@gmail.com",},
                new UserInfo{Name ="Oleg", Email = "oleg@gmail.com",}
            };
            info.ForEach(s => context.UserInfoes.AddOrUpdate(s));
            context.SaveChanges();

            var users = new List<User>
            {
                new User{Login = "Key",Password = "KeyPass", UserInfoId = info.Single(s=>s.Name=="Kate").Id, },
                new User{Login = "Leo",Password = "LeoPass", UserInfoId = info.Single(s=>s.Name=="Lew").Id, },
                new User{Login = "Olegek",Password = "OlegekPass", UserInfoId = info.Single(s=>s.Name=="Oleg").Id, }
            };
            users.ForEach(s => context.Users.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
