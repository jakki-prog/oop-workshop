using Domain.Interfaces;

namespace Domain.Media;

public abstract class MediaItem : IDownloadable{
    private static int _nextId = 1;
    private readonly List<int> _ratings = new();

    public int Id { get; }
    public string Title { get; }

    protected MediaItem(string title){
        if (string.IsNullOrWhiteSpace(title))
        throw new ArgumentException("Title cannot be empty!");

        Id = _nextId++;
        Title = title;
    }
    public abstract string Open();
    public virtual string Download(){
        return "Downloading" + Title ;
    }
    public void AddRating(int stars){
        if (stars < 1 || stars > 5)
        throw new ArgumentOutOfRangeException("Rating must be between 1-5 stars");
        _ratings.Add(stars);
    }
    public IReadOnlyList<int> Ratings{
        get { return _ratings; }
    }
}