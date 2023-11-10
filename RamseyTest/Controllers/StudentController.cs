using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RamseyTest.Core.Entities;
using RamseyTest.Core.Persistence;
using RamseyTest.Core.Repository;

namespace RamseyTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : GenericController<Student, StudentRepository>
    {
 
        public StudentController(StudentRepository repository) : base(repository)
        {
            
        }

    }
}
