using CRUDApplication.DAL;
using CRUDApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        {
            _context = context;     
        }

        // HTTP VERBS
        // GET 
        // POST
        // PUT
        // PATCH
        // DELETE

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _context.StudentTable.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(student);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _context.StudentTable.ToListAsync();
            return Ok(students); 
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
