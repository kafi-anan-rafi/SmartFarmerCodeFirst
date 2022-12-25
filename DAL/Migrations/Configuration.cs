namespace DAL.Migrations
{
    using DAL.EF.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Xml.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.FarmerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.FarmerContext context)
        {
            // seeding Order data
            /*List<Order> orders = new List<Order>();
            for (int i = 1; i <= 10; i++)
            {
                orders.Add(new Order()
                {
                    Id = i,
                    CustomerId = i,
                    Category = "Vegetable",
                    Date = DateTime.Now,
                    ProductId = i,
                    Quantity = i,
                    Status = "Pending"

                });
            }
            context.Orders.AddOrUpdate(orders.ToArray());*/

            // seeding Order data
            /*List<Advisor> advisors = new List<Advisor>();
            Random random = new Random();
            for (int i = 1; i <= 500; i++)
            {
                advisors.Add(new Advisor()
                {
                    Id = i,
                    Address = Guid.NewGuid().ToString(),
                    HourlyRate = 100 + i,
                    Name = Guid.NewGuid().ToString(),
                });
            }
            context.Advisors.AddOrUpdate(advisors.ToArray());*/
            List<User> Users = new List<User>();
            Random random = new Random();
            string[] type = { "Customer", "Farmer", "Doctor", "Advisor" };
            for (int i = 1; i <= 10; i++)
            {
                Users.Add(new User()
                {
                    Id = i,
                    Email = string.Format("qa{0:0000}@gmail.com", random.Next(10000)),
                    Password = Guid.NewGuid().ToString(),
                    Type = type[random.Next(i)%4],                   

                });
            }
            context.Users.AddOrUpdate(Users.ToArray());
        }
    }
}
