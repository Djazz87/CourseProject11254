using System;

namespace CourseProject1125.Models;

public class User
{
    public int Id  { get; set; }
    public string  Full_name { get; set; }
    public string  Email { get; set; }
    public string Phone { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Password_hash { get; set; }
    public DateTime Registration_date { get; set; }
    public Role RoleId { get; set; }
}