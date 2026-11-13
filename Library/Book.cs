namespace Library
{
    public class Book //bara placeholder tills jag vet hur den kmr se ut sen
    {
        public string Title { get; }
        public string ISBN { get; }
        public bool IsAvailable { get; set; }
        public Book(string title, string isbn, bool isAvailable)
        {
            Title = title;
            ISBN = isbn;
            IsAvailable = isAvailable;
        }
    }
}