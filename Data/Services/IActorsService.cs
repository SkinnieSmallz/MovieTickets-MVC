using ecommerce_mvc.Models;

namespace ecommerce_mvc.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync(); // Get all actors
        Task <Actor> GetByIdAsync(int id); // Get single actor by id
        Task AddAsync(Actor actor);
        Actor Update(int id, Actor newActor); // Update data in db
        void Delete(int id);
    }
}
