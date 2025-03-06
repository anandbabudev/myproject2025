using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("Department")]
public class Department
{
    public int DepartmentID { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
}
