using ecommerce_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ecommerce_mvc.Data.Services
{
    public class ActorsService : IActorsService  // Implement interface
    {
        private readonly AppDbContext _context;  // Injecting AppdbContext
        public ActorsService(AppDbContext context) // constructor
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
