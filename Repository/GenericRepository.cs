using Microsoft.EntityFrameworkCore;
using RepositoryPattern.DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.Repository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        /*
         * DECOUPLAGE de l'ORM
         *
         * C'est dans l'implementation que je décide d'utiliser ENTITY FRAMEWORK.
         * C'est GENERIQUE, ça n'a rien à voir avec le context de notre application.
         */

        protected DbContext _context;

        public GenericRepository(MyAppContext context)
        {
            _context = context;
        }

        public IEnumerable<Entity> GetAll()
        {
            return _context.Set<Entity>().ToList();
        }

        public Entity GetById(int id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public void Add(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
        }

        public void Remove(Entity entity)
        {
            _context.Set<Entity>().Remove(entity);
        }
    }
}