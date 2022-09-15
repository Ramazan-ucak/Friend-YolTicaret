namespace BitirmeFriendyol.Migrations
{
    using BitirmeFriendyol.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BitirmeFriendyol.Models.DBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BitirmeFriendyol.Models.DBModel context)
        {
            context.ManagerTypes.AddOrUpdate(s => s.ID, new ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(s => s.ID, new ManagerType() { ID = 2, Name = "Moderator" });
            context.Managers.AddOrUpdate(s => s.ID, new Manager() { ID = 1, Name = "Necip", Surname = "Uysal", Mail = "uysal@gmail.com", Password = "1234", ManagerType_ID = 1, ProfileImage = "none.jpg", Status = true, CreationDate = Convert.ToDateTime("05/08/2022") });
        }
    }
}
