using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(string name, string email = null)
        {
            using var db = new AppContext();

            var user = new User { Name = name, Email = email };

            db.Users.Add(user);

            db.SaveChanges();
        }

        public void Update(User user)
        {
            using var db = new AppContext();
            db.Users.Update(user);

            db.SaveChanges();
        }

        public void RemoveUserById(int idUser)
        {
            using var db = new AppContext();

            var removeUser = db.Users.Where(x => x.Id == idUser).ToList();

            if (removeUser.FirstOrDefault() == null)
            {
                throw new NullIdException();
            }

            db.Users.Remove(removeUser.FirstOrDefault()!);

            db.SaveChanges();
        }

        public List<User> SelectUserById(int idUser)
        {
            using var db = new AppContext();

            var selectUserById = db.Users.Where(x => x.Id == idUser).ToList();


            if (selectUserById.FirstOrDefault() == null)
            {
                throw new NullIdException();
            }

            return selectUserById;
        }

        public List<User> SelectAllUser()
        {
            using var db = new AppContext();

            var allUsers = db.Users.ToList();

            return allUsers;
        }

        public void UpdateUserById(int idUser, string name)
        {
            using var db = new AppContext();

            var user = db.Users.Where(s => s.Id == idUser).ToList();

            if (user.FirstOrDefault() == null)
            {
                throw new NullIdException();
            }

            user.FirstOrDefault()!.Name = name;

            db.SaveChanges();
        }
    }
}