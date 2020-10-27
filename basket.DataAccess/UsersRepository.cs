using basket.DataAccess.Data;
using basket.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace basket.DataAccess
{
    public class UsersRepository
    {
        private UsersContext db = new UsersContext();

        public User GetUser(string userId)
        {
            User user = db.Users.FirstOrDefault(x => x.Username == userId);

            return user;
        }

        public void Create(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
