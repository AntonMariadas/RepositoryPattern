using System.Collections.Generic;

namespace RepositoryPattern.Repository
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        IEnumerable<Entity> GetAll();

        Entity GetById(int id);

        void Add(Entity entity);

        void Remove(Entity entity);
    }
}