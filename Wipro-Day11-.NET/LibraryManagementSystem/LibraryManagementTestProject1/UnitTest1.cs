using NUnit.Framework;
using LibraryManagementSystem;
using System;
namespace LibraryManagementTestProject1
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookSuccessfully()
        {
            var book = new Book("Clean Code", "Robert C. Martin", "978-0132350884");

            _library.AddBook(book);

            Assert.That(_library.Books.Count, Is.EqualTo(1));
            Assert.That(_library.Books[0].Title, Is.EqualTo("Clean Code"));
        }

        [Test]
        public void RegisterBorrower_ShouldRegisterSuccessfully()
        {
            var borrower = new Borrower("Alice Smith", "CARD001");

            _library.RegisterBorrower(borrower);

            Assert.That(_library.Borrowers.Count, Is.EqualTo(1));
            Assert.That(_library.Borrowers[0].Name, Is.EqualTo("Alice Smith"));
        }

        [Test]
        public void BorrowBook_ValidData_ShouldMarkAsBorrowed()
        {
            var book = new Book("Domain-Driven Design", "Eric Evans", "978-0321125217");
            _library.AddBook(book);

            var borrower = new Borrower("Bob", "CARD002");
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("978-0321125217", "CARD002");

            Assert.IsTrue(book.IsBorrowed);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(1));
            Assert.That(borrower.BorrowedBooks[0].ISBN, Is.EqualTo("978-0321125217"));
        }

        [Test]
        public void ReturnBook_ValidData_ShouldMarkAsAvailable()
        {
            var book = new Book("Refactoring", "Martin Fowler", "978-0201485677");
            _library.AddBook(book);

            var borrower = new Borrower("Charlie", "CARD003");
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("978-0201485677", "CARD003");
            _library.ReturnBook("978-0201485677", "CARD003");

            Assert.IsFalse(book.IsBorrowed);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(0));
        }

        [Test]
        public void BorrowBook_NonExistingBook_ShouldThrowException()
        {
            var borrower = new Borrower("Dave", "CARD004");
            _library.RegisterBorrower(borrower);

            Assert.Throws<InvalidOperationException>(() =>
                _library.BorrowBook("999-9999999999", "CARD004"));
        }
    }
}