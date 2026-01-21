using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public bool IsBorrowed { get; private set; }

        public Book(string title, string author, string isbn)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title cannot be empty");
            if (string.IsNullOrWhiteSpace(author)) throw new ArgumentException("Author cannot be empty");
            if (string.IsNullOrWhiteSpace(isbn)) throw new ArgumentException("ISBN cannot be empty");

            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed)
                throw new InvalidOperationException($"Book '{Title}' is already borrowed.");

            IsBorrowed = true;
        }

        public void Return()
        {
            if (!IsBorrowed)
                throw new InvalidOperationException($"Book '{Title}' is not borrowed.");

            IsBorrowed = false;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN}) - {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}