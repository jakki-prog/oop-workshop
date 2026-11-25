using Domain.Media;

namespace oop_workshop;

class Program
{
    static void Main(string[] args)
    {
        MediaItem book = new Ebook("The Hunger Games", "Suzanne Collins", "English", 374, 2008, "978-0-439-02352-8");
                Console.WriteLine(book.Download());
                Console.WriteLine(book.Open());
                book.AddRating(5);
                Console.WriteLine(book.Ratings.Count);
                Console.WriteLine(book.Ratings.Average());
    }
}

