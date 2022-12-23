namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.FarmerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.FarmerContext context)
        {
            // seeding some Orders
            List<Order> orders = new List<Order>();
            for (int i = 1; i <= 10; i++)
            {
                orders.Add(new Order()
                {
                    Id = i,
                    ProductId = i,
                    Quantity = i,
                    Category = "Vegetable",
                    CustomerId = i,
                    Date = DateTime.Now,
                    Status = "Pending"
                }) ;
            }
            context.Orders.AddOrUpdate(orders.ToArray());

            // seeding some Orders
            List<Advisor> advisors = new List<Advisor>();
            for (int i = 1; i <= 10; i++)
            {
                advisors.Add(new Advisor()
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString(),
                    Address = Guid.NewGuid().ToString(),
                    HourlyRate = i+100,
                });
            }
            context.Advisors.AddOrUpdate(advisors.ToArray());
        }
    }
}
