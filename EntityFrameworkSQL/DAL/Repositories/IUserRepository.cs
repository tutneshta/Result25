using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;

namespace EntityFrameworkSQL.DAL.Repositories
{
    internal interface IUserRepository
    {
        public void AddUser(string name, string email = null!);
        public void RemoveUserById(int idUser);
        public List<User> SelectUserById(int idUser);
        public List<User> SelectAllUser();
        public void UpdateUserById(int idUser, string name);
    }
}