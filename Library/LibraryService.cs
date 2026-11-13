namespace Library
{
    public class LibraryService
    {
        public bool BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                return true;
            }
            return false;
        }
    }
}