using API.DBContext;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController(DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetUsers(){
            return await context.Employees.ToListAsync();
        }
    }
}
