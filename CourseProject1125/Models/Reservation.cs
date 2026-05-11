using System;

namespace CourseProject1125.Models;

public class Reservation
{
    public int Id { get; set; }
    public DateTime Reservation_date { get; set; }
    public DateTime Expiry_date { get; set; }
    public int is_active { get; set; }
    public Book BookId { get; set; }
    public User ReaderId { get; set; }
}