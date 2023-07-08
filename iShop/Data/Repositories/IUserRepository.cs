using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iShop.Models;

namespace iShop.Data.Repositories
{
   public interface IUserRepository
   {
       bool DoesExistUserByEmail(string email);
       void AddUser(Users user);
       Users GetUserForLogin(string email, string password);
   }

    public class UserRepository : IUserRepository
    {
        private iShopContext _context;

        public UserRepository(iShopContext context)
        {
            _context = context;
        }

        public bool DoesExistUserByEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public void AddUser(Users user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public Users GetUserForLogin(string email, string password)
        {
            return _context.Users
                .SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }

}
