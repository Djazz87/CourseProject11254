using System;

namespace CourseProject1125.Models;

public class Loan
{
    public int Id { get; set; }
    public string Status { get; set; }
    public DateTime Issue_date { get; set; }
    public DateTime Due_date { get; set; }
    public DateTime Return_date { get; set; }
    public Book CopyId { get; set; }
    public User ReaderId { get; set; }
    public User LibrarianId { get; set; }
    
}