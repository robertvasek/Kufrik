public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Subtitle { get; set; }
    public string Content { get; set; }
    public string[] ImageUrls { get; set; }
}

public class Question
{
    public string QuestionQ { get; set; }
    public string AnswerQ { get; set; }
}

public class Trip
{
    public string Country { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Price { get; set; }
    public int Capacity { get; set; }
    public string ShortDescription { get; set; }
    public string[] ImageUrls { get; set; }
}