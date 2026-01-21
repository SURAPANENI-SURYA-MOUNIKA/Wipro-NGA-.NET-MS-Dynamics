using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly List<Borrower> _borrowers = new List<Borrower>();

        public IReadOnlyList<Book> Books => _books.AsReadOnly();
        public IReadOnlyList<Borrower> Borrowers => _borrowers.AsReadOnly();

        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            if (_books.Any(b => b.ISBN == book.ISBN))
                throw new InvalidOperationException($"Book with ISBN {book.ISBN} already exists.");

            _books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            if (borrower == null) throw new ArgumentNullException(nameof(borrower));
            if (_borrowers.Any(b => b.LibraryCardNumber == borrower.LibraryCardNumber))
                throw new InvalidOperationException($"Borrower with card {borrower.LibraryCardNumber} already registered.");

            _borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = _books.FirstOrDefault(b => b.ISBN == isbn)
                ?? throw new InvalidOperationException($"Book with ISBN {isbn} not found.");

            var borrower = _borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber)
                ?? throw new InvalidOperationException($"Borrower with card {libraryCardNumber} not found.");

            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var book = _books.FirstOrDefault(b => b.ISBN == isbn)
                ?? throw new InvalidOperationException($"Book with ISBN {isbn} not found.");

            var borrower = _borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber)
                ?? throw new InvalidOperationException($"Borrower with card {libraryCardNumber} not found.");

            borrower.ReturnBook(book);
        }

        public void ViewBooks()
        {
            Console.WriteLine("\n===== Library Books =====");
            if (!_books.Any())
                Console.WriteLine("No books in library.");
            else
                foreach (var book in _books)
                    Console.WriteLine(book);
        }

        public void ViewBorrowers()
        {
            Console.WriteLine("\n===== Registered Borrowers =====");
            if (!_borrowers.Any())
                Console.WriteLine("No borrowers registered.");
            else
                foreach (var borrower in _borrowers)
                {
                    Console.WriteLine(borrower);
                    if (borrower.BorrowedBooks.Any())
                    {
                        Console.WriteLine("  Borrowed:");
                        foreach (var b in borrower.BorrowedBooks)
                            Console.WriteLine($"    - {b.Title} ({b.ISBN})");
                    }
                }
        }
    }
}