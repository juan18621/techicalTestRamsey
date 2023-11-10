using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RamseyTest.Core.Entities;
using RamseyTest.Core.Repository;

namespace RamseyTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public GenericController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var movie = await repository.Get(id);
            if (movie == null)
            {
                throw new KeyNotFoundException();
            }
            return movie;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                throw new ApplicationException();
            }
            await repository.Update(entity);
            return Ok();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity movie)
        {
            await repository.Add(movie);
            return CreatedAtAction("Get", new { id = movie.Id }, movie);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var movie = await repository.Delete(id);
            if (movie == null)
            {
                throw new KeyNotFoundException();
            }
            return movie;
        }

    }
}
