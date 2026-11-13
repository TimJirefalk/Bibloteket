using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Tests
{
    [TestClass]
    public sealed class LibraryServiceTests
    {
        [TestMethod]
        public void BorrowBook_AvailableBook_BecomesUnavailable()
        {
            Book book = new("ABC", "ISDN1234567890", true); //true = boken ska finnas
            LibraryService library = new();

            bool result = library.BorrowBook(book);

            Assert.IsTrue(result);
            Assert.IsFalse(book.IsAvailable);
        }
        [TestMethod]
        public void BorrowBook_UnavailableBook_RemainsUnavailable()
        {
            Book book = new("ABC", "ISBN1234567890", false); //false = boken är utlånad
            LibraryService library = new();

            bool result = library.BorrowBook(book);

            Assert.IsFalse(result);
            Assert.IsFalse(book.IsAvailable);
        }
    }
}