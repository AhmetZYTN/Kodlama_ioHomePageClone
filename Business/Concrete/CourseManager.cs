using Kodlama_ioHomePageClone.Business.Abstract;
using Kodlama_ioHomePageClone.DataAccess.Abstract;
using Kodlama_ioHomePageClone.DataAccess.Concrete;
using Kodlama_ioHomePageClone.Models;

namespace Kodlama_ioHomePageClone.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private static List<Course> _courses = new List<Course>();

        public List<Course> GetList()
        {
            return _courses;
        }

        public void CourseAdd(Course course)
        {
            course.CourseId = GenerateId();
            _courses.Add(course);
        }

        public void CourseDelete(int courseId)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.CourseId == courseId);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public void CourseUpdate(Course updatedCourse)
        {
            Course existingCourse = _courses.FirstOrDefault(c => c.CourseId == updatedCourse.CourseId);
            if (existingCourse != null)
            {
                existingCourse.Title = updatedCourse.Title;
                existingCourse.InstructorId = updatedCourse.InstructorId;
                existingCourse.Price = updatedCourse.Price;
                existingCourse.Completed = updatedCourse.Completed;
                existingCourse.Description = updatedCourse.Description;
                existingCourse.Category = updatedCourse.Category;
                existingCourse.CategoryId = updatedCourse.CategoryId;
                existingCourse.Student = updatedCourse.Student;
            }
        }

        public Course GetCourseById(int courseId)
        {
            return _courses.FirstOrDefault(c => c.CourseId == courseId);
        }

        public int GenerateId()
        {
            return _courses.Count + 1;
        }
    }
}
