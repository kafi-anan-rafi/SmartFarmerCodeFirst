using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
    }
}
