namespace Domain.Media;

public class Ebook : MediaItem {
    public string Author { get; }
    public string Language { get; }
    public int Pages { get; }
    public int Year { get;}
    public string ISBN { get; }

    public Ebook(string title, string author, string language, int pages, int year, string isbn) : base(title){
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be empty");
        if (pages<=0)
            throw new ArgumentException("Book must contain more than 0 pages");

        Author = author;
        Language = language;
        Pages = pages;
        Year = year;
        ISBN = isbn;
    }
    public override string Open(){
        return "Reading" + Title + "by" + Author;
    }
    
}
