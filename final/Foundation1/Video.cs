
// Video.cs

public class Video
{
    // Properties to store the title, author, and length of the video
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    // Private list to store the comments for the video
    private List<Comment> comments;

    // Constructor to initialize the video properties and instantiate the comments list
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to return the number of comments for the video
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to return the list of comments for the video
    public List<Comment> GetComments()
    {
        return comments;
    }
}