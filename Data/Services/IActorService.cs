using e_shows.Models;

namespace e_shows.Data.Services
{
    public interface IActorService
    {
        // to get all the actors
        Task<IEnumerable<Actor>> GetActors();

        // to get single actor by ID
        Actor GetActorByID(int ID);

        // to add an actor in the database
        void AddActor(Actor actor);

        // to update the existing actor in the database
        Actor Update(int ID, Actor actor);

        // to delete an actor from the database
        void DeleteActor(Actor actor);
    }
}
