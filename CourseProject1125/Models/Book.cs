namespace CourseProject1125.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Isbn { get; set; }
    public string Description { get; set; }
    public int Year_published { get; set; }
    public Author AuthorId { get; set; }
}