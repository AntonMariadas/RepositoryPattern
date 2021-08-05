using RepositoryPattern.Models;
using System.Collections.Generic;

namespace RepositoryPattern.Repository
{
    /*
     * HERITAGE
     *
     * Une interface ne peut pas Implementer.
     * Je récupère les methodes communes CRUD par Héritage.
     * Je rajoute les méthodes Spécifiques à ce Repository.
     */

    internal interface ICourseRepository : IGenericRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);

        IEnumerable<Course> GetCoursesWithAuthors();
    }
}