using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Borrower
    {
        public string Name { get; }
        public string LibraryCardNumber { get; }
        public List<Book> BorrowedBooks { get; } = new List<Book>();

        public Borrower(string name, string libraryCardNumber)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty");
            if (string.IsNullOrWhiteSpace(libraryCardNumber)) throw new ArgumentException("Card number cannot be empty");

            Name = name;
            LibraryCardNumber = libraryCardNumber;
        }

        public void BorrowBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            book.Borrow();              // throws if already borrowed
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            if (!BorrowedBooks.Contains(book))
                throw new InvalidOperationException($"Borrower {Name} does not have book '{book.Title}'");

            book.Return();
            BorrowedBooks.Remove(book);
        }

        public override string ToString()
        {
            return $"{Name} ({LibraryCardNumber}) - Borrowed books: {BorrowedBooks.Count}";
        }
    }
}