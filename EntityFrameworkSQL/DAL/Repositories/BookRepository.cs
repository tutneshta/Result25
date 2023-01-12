using EntityFrameworkSQL.BLL.Exception;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.PLL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace EntityFrameworkSQL.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private UserRepository userRepository;
        private BookRepository bookRepository;

        public void AddBook(string title, DateTime date, string author = null, string genre = null)
        {
            using var db = new AppContext();

            var book = new Book { Title = title, Date = date, Author = author, Genre = genre };

            db.Books.Add(book);

            db.SaveChanges();
        }

        public void RemoveBookById(int idBook)
        {
            using var db = new AppContext();

            var removeBook = db.Books.Where(x => x.Id == idBook).ToList();

            if (removeBook.FirstOrDefault() == null)
            {
                throw new NullIdException();
            }

            db.Books.Remove(removeBook.FirstOrDefault()!);
            db.SaveChanges();
        }

        public List<Book> SelectBookById(int idBook)
        {
            using var db = new AppContext();

            var selectBookById = db.Books.Where(x => x.Id == idBook).ToList();

            if (selectBookById.FirstOrDefault() == null)
            {
                throw new NullIdException();
            }

            return selectBookById;
        }

        public List<Book> SelectAllBooks()
        {
            using var db = new AppContext();

            var allBookss = db.Books.ToList();

            return allBookss;
        }

        public void UpdateDateBookById(int idBook, DateTime date)
        {
            using var db = new AppContext();

            var book = db.Books.Where(s => s.Id == idBook).ToList();

            if (book.FirstOrDefault() == null)
            {
                throw new NullIdException();
            }

            book.FirstOrDefault()!.Date = date;
            db.SaveChanges();
        }

        public List<User> SelectAllBooksInUser(int idUser)
        {
            using var db = new AppContext();

            userRepository = new UserRepository();

            var users = db.Users.Include(c => c.Books).ToList().Where(s => s.Id == idUser);

            return users.ToList();
        }

        public List<Book> SelectBookGenreAndDate(string genre, DateTime date1, DateTime date2)
        {
            using var db = new AppContext();

            var books = db.Books.Where(s => s.Genre == genre).Where(s => s.Date >= date1).Where(s => s.Date <= date2);

            return books.ToList();
        }

        public int CountBooksAuthor(string author)
        {
            using var db = new AppContext();

            int count = db.Books.Count(s => s.Author == author);

            return count;
        }

        public int CountBooksGenre(string? genre)
        {
            using var db = new AppContext();

            int count = db.Books.Count(s => s.Genre == genre);

            return count;
        }

        public bool GetBookTitleAndAuthor(string title, string author)
        {
            using var db = new AppContext();

            var books = db.Books.Where(s => s.Author == author).Where(s => s.Title == title);

            return books.Any();
        }

        public bool GetBookInUser(string title)
        {
            using var db = new AppContext();

            var isTrue = false;

            var users = db.Users.Include(c => c.Books).ToList();

            foreach (var use in users)
            {
                foreach (var book in use.Books)
                {
                    if (book.Title == title)
                    {
                        isTrue = true;
                    }
                }
            }

            return isTrue;
        }

        public int CountBookInUser(int idUser)
        {
            using var db = new AppContext();

            userRepository = new UserRepository();

            var users = db.Users.Include(c => c.Books).ToList().Where(s => s.Id == idUser);
            int count = 0;

            foreach (var user in users)
            {
                foreach (var book in user.Books)
                {
                    count++;
                }
            }

            return count;
        }

        public Book GetLastBook()
        {
            using var db = new AppContext();

            return db.Books.OrderBy(s => s.Date).LastOrDefault()!;
        }

        public List<Book> GetAllBooksSortTitle()
        {
            return SelectAllBooks().OrderBy(s => s.Title).ToList();
        }

        public List<Book> GetAllBooksSortDateDesc()
        {
            return SelectAllBooks().OrderByDescending(s => s.Date).ToList();
        }
    }
}