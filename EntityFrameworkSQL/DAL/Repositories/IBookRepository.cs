using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;

namespace EntityFrameworkSQL.DAL.Repositories
{
    internal interface IBookRepository
    {
        public void AddBook(string title, DateTime date, string author, string genre);
        public void RemoveBookById(int idBook);
        public List<Book> SelectBookById(int idBook);
        public List<Book> SelectAllBooks();
        public void UpdateDateBookById(int idBook, DateTime date);
        public List<User> SelectAllBooksInUser(int idUser);
        public List<Book> SelectBookGenreAndDate(string genre, DateTime date1, DateTime date2);
        public int CountBooksAuthor(string author);
        public int CountBooksGenre(string? genre);
        public bool GetBookTitleAndAuthor(string title, string author);
        public bool GetBookInUser(string title);
        public int CountBookInUser(int idUser);
        public Book GetLastBook();
        public List<Book> GetAllBooksSortTitle();
        public List<Book> GetAllBooksSortDateDesc();
    }
}