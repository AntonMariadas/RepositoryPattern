using RepositoryPattern.DataAccessLayer;
using RepositoryPattern.Models;
using System.Collections.Generic;

namespace RepositoryPattern.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(MyAppContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            // return _context.Course.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors()
        {
            // return _context.Courses.Include(c => c.Author).OrderBy(c => c.Name).ToList();
        }
    }
}