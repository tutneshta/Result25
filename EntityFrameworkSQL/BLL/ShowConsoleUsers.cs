using EntityFrameworkSQL.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.BLL
{
    internal class ShowConsoleUsers
    {
        public static void Show(List<User> users)
        {
            Console.Clear();
            Console.WriteLine("{0,-5} {1,-20} {2,-20}", "id", "Имя", "Email");
            Console.WriteLine();

            foreach (var user in users)
            {
                Console.WriteLine(
                    "{0,-5} {1,-20} {2,-20}", $"{user.Id}", $"{user.Name}", $"{user.Email}");
            }

            Console.WriteLine();
        }
    }
}