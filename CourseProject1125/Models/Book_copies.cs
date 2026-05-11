namespace CourseProject1125.Models;

public class Book_copies
{
    public int Id { get; set; }
    public string Inventroy_number { get; set; }
    public string Status { get; set; }
    public string Shelf_location { get; set; }
    public Book BookId { get; set; }
    
}