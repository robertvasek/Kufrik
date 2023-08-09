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