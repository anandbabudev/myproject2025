using System;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DBContext;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
    :base(options)
    {
        
    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Department { get; set; }
    public List<Employee> GetEmployees(){
            return Employees.ToList();
    }
}
