using DAL.EF.Model;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DataAccessFactory
    {
        // Rafi
        public static IRepo<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
        public static IRepo<Order, int, Order> OrderDataAccess()
        {
            return new OrderRepo();
        }
        public static IRepo<User, int, User> UserAccess()
        {
            return new UserRepo();
        }

        // Shadman
        public static IRepo<Farmer, int, Farmer> FarmerDataAccess()
        {
            return new FarmerRepo();
        }
        public static IRepo<Equipment, int, Equipment> EquipmentDataAccess()
        {
            return new EquipmentRepo();
        }
        public static IRepo<Loan, int, Loan> LoanDataAccess()
        {
            return new LoanRepo();
        }

        //Ridan
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }
        public static IRepo<Customer, int, Customer> CustomerAccess()
        {
            return new CustomerRepo();
        }
        public static IRepo<Product, int, Product> ProductAccess()
        {
            return new ProductRepo();
        }
        public static IRepo<Comment, int, Comment> CommentAccess()
        {
            return new CommentRepo();
        }

        // Anisur

        public static IRepo<Doctor, int, Doctor> DoctorAccess()
        {
            return new DoctorRepo();
        }
        public static IRepo<Service, int, Service> ServiceAccess()
        {
            return new ServiceRepo();
        }
        public static IRepo<Rating, int, Rating> RatingAccess()
        {
            return new RatingRepo();
        }

    }
    
}
