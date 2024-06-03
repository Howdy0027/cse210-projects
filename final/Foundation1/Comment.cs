// Comment.cs
public class Comment
{
    // Properties to store the name of the commenter and the text of the comment
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the comment properties
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}