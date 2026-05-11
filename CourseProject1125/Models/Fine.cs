using System;

namespace CourseProject1125.Models;

public class Fine
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public int Is_paid { get; set; }
    public DateTime Created_at { get; set; }
    public Loan LoanId { get; set; }
}