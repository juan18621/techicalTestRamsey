using RamseyTest.Core.Entities;
using RamseyTest.Core.Persistence;

namespace RamseyTest.Core.Repository
{
    public class StudentRepository : EfCoreRepository<Student, ApplicationDbContext>
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
