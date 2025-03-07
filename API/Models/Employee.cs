using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("Employee")]
public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBrith { get; set; }
    public string Gender { get; set; }
    public int DepartmentId { get; set; }
    public string PhotoPath { get; set; }

}
