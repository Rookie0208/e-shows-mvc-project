using e_shows.Models;
using Microsoft.EntityFrameworkCore;

namespace e_shows.Data.Services
{
    
    public class ActorService : IActorService
    {
        private readonly eshowsContext _context;
        public ActorService(eshowsContext context)
        {
            _context = context;
        }
        public void AddActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void DeleteActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorByID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            var result = await _context.Actor.ToListAsync();
            return result;
        }

        public Actor Update(int ID, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
